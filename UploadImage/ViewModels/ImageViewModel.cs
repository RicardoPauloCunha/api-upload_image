using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
