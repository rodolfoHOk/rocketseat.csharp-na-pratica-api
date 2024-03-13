using CloudStorageSolution.Domain.Storage;
using dotenv.net;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Drive.v3;
using Microsoft.AspNetCore.Http;

namespace CloudStorageSolution.Infrastructure.Storage;

public class GoogleDriveStorageService : IStorageService
{
    private readonly GoogleAuthorizationCodeFlow _authorizationCodeFlow;

    public GoogleDriveStorageService(GoogleAuthorizationCodeFlow authorizationCodeFlow)
    {
        _authorizationCodeFlow = authorizationCodeFlow;
    }

    public string Upload(IFormFile file, Domain.Entities.User user)
    {
        var credential = new UserCredential(_authorizationCodeFlow, user.Email, new TokenResponse
        {
            AccessToken = user.AccessToken,
            RefreshToken = user.RefreshToken
        });

        var envVars = DotEnv.Read();

        var service = new DriveService(new Google.Apis.Services.BaseClientService.Initializer
        {
            ApplicationName = envVars["CLOUD_STORAGE_APPLICATION_NAME"],
            HttpClientInitializer = credential
        });

        var driveFile = new Google.Apis.Drive.v3.Data.File
        {
            Name = file.Name,
            MimeType = file.ContentType
        };

        var command = service.Files.Create(driveFile, file.OpenReadStream(), file.ContentType);
        command.Fields = "id";

        var response = command.Upload();

        if (response.Status is not Google.Apis.Upload.UploadStatus.Completed)
            throw response.Exception;
        
        return command.ResponseBody.Id;        
    }
}
