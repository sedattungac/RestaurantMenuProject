﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FoodCategory
    {
        [Key]
        public int FoodCategoryId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
