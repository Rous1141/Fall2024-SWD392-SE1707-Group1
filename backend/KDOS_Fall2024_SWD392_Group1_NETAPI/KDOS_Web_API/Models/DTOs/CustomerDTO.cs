﻿using System;
namespace KDOS_Web_API.Models.DTOs
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public String? CustomerName { get; set; }
        public int Age { get; set; }
        public String? Gender { get; set; }
        public String? Email { get; set; }
        public String? PhoneNumber { get; set; }
        public String? Address { get; set; }
    }
}
