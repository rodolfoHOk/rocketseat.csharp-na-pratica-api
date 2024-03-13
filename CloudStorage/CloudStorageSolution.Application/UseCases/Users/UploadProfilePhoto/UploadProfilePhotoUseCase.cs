using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorageSolution.Application.UseCases.Users.UploadProfilePhoto;

public class UploadProfilePhotoUseCase
{
  public void Execute(IFormFile file)
  {
    var fileStream = file.OpenReadStream();

    var isJpegImage = fileStream.Is<JointPhotographicExpertsGroup>();

    if (isJpegImage == false) 
      throw new Exception("The file is not an jpeg image.");
  }
}