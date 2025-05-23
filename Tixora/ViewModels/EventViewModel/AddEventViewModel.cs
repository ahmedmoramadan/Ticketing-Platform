﻿using Tixora.Settings;
using Tixora.Validation;

namespace Tixora.ViewModels.EventViewModel
{
    public class AddEventViewModel : EventViewModel
    {
        [AllowExtentions(FileSettings.AllowExtentions),
           MixSize(FileSettings.maxSizeByByets)]
        public IFormFile Cover { get; set; } = default!;
    }
}
