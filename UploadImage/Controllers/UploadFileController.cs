using System;
using Microsoft.AspNetCore.Mvc;
using UploadImage.Interfaces;
using UploadImage.ViewModels;

namespace UploadImage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IUploadFileRepository _uploadFileRepository;

        public UploadFileController(IUploadFileRepository uploadFileRepository)
        {
            _uploadFileRepository = uploadFileRepository;
        }

        [HttpPost]
        public IActionResult Upload([FromForm]ImageViewModel imageViewModel)
        {
            try
            {
                var request = _uploadFileRepository.Upload(imageViewModel);

                return Ok(request.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}