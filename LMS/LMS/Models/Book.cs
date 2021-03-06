﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public ICollection<BorrowHistory> BorrowHistories { get; set; }
    }
}