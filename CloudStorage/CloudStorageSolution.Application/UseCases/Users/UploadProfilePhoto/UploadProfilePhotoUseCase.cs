using CloudStorageSolution.Domain.Entities;
using CloudStorageSolution.Domain.Storage;
using dotenv.net;
using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorageSolution.Application.UseCases.Users.UploadProfilePhoto;

public class UploadProfilePhotoUseCase : IUploadProfilePhotoUseCase
{
  private readonly IStorageService _storageService;

  public UploadProfilePhotoUseCase(IStorageService storageService)
  {
    _storageService = storageService;
  }

  public void Execute(IFormFile file)
  {
    var fileStream = file.OpenReadStream();

    var isJpegImage = fileStream.Is<JointPhotographicExpertsGroup>();

    if (isJpegImage == false)
      throw new Exception("The file is not an jpeg image.");

    _storageService.Upload(file, GetFromDatabase());
  }

  private User GetFromDatabase() {
    var envVars = DotEnv.Read();
    
    return new User 
    {
      Id = 1,
      Name = "Rudolf HiOk",
      Email = envVars["CLOUD_STORAGE_CLIENT_EMAIL"],
      AccessToken = envVars["CLOUD_STORAGE_ACCESS_TOKEN"],
      RefreshToken = envVars["CLOUD_STORAGE_REFRESH_TOKEN"]
    };
  }
}
