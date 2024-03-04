﻿using ProductReview.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProductReview.Domain.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
        public string PicturePath { get; set; }
        public List<Product> Products { get; set; }
    }
}
