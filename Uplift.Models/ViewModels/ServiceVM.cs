﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uplift.Models.ViewModels
{
    public class ServiceVM
    {
        
        public Service Service { get; set; }

        public IEnumerable<SelectListItem>? CategoryList { get; set; }

        public IEnumerable<SelectListItem>? FrequencyList { get; set; }

    }
}
