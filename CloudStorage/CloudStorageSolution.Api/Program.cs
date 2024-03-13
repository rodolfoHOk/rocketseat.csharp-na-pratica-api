using CloudStorageSolution.Application.UseCases.Users.UploadProfilePhoto;
using CloudStorageSolution.Domain.Storage;
using CloudStorageSolution.Infrastructure.Storage;
using dotenv.net;
using dotenv.net.Utilities;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;

DotEnv.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStorageService>(options => 
{
    // var clientId = builder.Configuration.GetValue<string>("CloudStorage:ClientId"); // usando .env ao invés deste
    // var clientSecret = builder.Configuration.GetValue<string>("CloudStorage:ClientSecret"); // usando .env ao invés deste
    var clientId = EnvReader.GetStringValue("CLOUD_STORAGE_CLIENT_ID");
    var clientSecret = EnvReader.GetStringValue("CLOUD_STORAGE_CLIENT_SECRET");

    var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer{
        ClientSecrets = new ClientSecrets {
            ClientId = clientId,
            ClientSecret = clientSecret
        },
        Scopes = [Google.Apis.Drive.v3.DriveService.Scope.Drive],
        DataStore = new FileDataStore(EnvReader.GetStringValue("CLOUD_STORAGE_APPLICATION_NAME"))
    });

    return new GoogleDriveStorageService(apiCodeFlow);
});

builder.Services.AddScoped<IUploadProfilePhotoUseCase, UploadProfilePhotoUseCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
