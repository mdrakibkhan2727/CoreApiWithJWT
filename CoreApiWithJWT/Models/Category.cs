﻿using System.ComponentModel.DataAnnotations;

namespace CoreApiWithJWT.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
    }
}
