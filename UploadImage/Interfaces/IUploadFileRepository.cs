﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadImage.ViewModels;

namespace UploadImage.Interfaces
{
    public interface IUploadFileRepository
    {
        Task<ResultViewModel> Upload(ImageViewModel imageViewModel);
    }
}
