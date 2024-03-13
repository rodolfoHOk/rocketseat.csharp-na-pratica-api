using Microsoft.AspNetCore.Mvc;

namespace CloudStorageSolution.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StorageController : ControllerBase
{
  [HttpPost]
  public IActionResult UploadImage(IFormFile file)
  {
    return Created();
  }
}
