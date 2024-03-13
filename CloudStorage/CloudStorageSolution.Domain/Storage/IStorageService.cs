using CloudStorageSolution.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace CloudStorageSolution.Domain.Storage;

public interface IStorageService
{
  string Upload(IFormFile file, User user);
}
