﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Venu.Models.Models
{
	public class Company
	{
        [Key]
		public int id { get; set; }
        [Required]
		public string? Name { get; set; }
        [Required]
        public string? StreetAddress { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        public string? PostalCode { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }


    }
}

