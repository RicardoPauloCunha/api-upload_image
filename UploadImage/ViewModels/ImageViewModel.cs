using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace UploadImage.ViewModels
{
    public class ImageViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public IFormFile ImageFile { get; set; }

        public ImageViewModel()
        {

        }
    }
}
