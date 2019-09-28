using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class book
    {
        [Required]
        [MaxLength(20,ErrorMessage ="at most 20")]
        [MinLength(5, ErrorMessage = "at least 5")]
        public string tittle { get; set; }
        [Required]
        public int numberOfPages { get; set; }
    }
}