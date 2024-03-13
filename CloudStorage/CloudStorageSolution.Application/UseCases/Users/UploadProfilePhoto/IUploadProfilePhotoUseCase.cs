using Microsoft.AspNetCore.Http;

namespace CloudStorageSolution.Application.UseCases.Users.UploadProfilePhoto;

public interface IUploadProfilePhotoUseCase
{
  void Execute(IFormFile file);
}
