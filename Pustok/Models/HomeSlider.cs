﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class HomeSlider
    {
        public int Id { get; set; }
        public int Order { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Desc { get; set; }
        public string Image { get; set; }
        [MaxLength(50)]
        public string BtnText { get; set; }
        [MaxLength(250)]
        public string BtnUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
