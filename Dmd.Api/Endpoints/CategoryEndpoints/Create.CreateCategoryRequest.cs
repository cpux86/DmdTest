﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class CreateCategoryRequest
    {
        //[Required]
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        
        //[Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Responce<string>), ErrorMessage = "Please enter valid integer Number")]
        public int? Parent { get; set; }
    }
}