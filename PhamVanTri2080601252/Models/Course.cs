using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhamVanTri2080601252.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lectuter { get; set; }
        [Required]
        public string LectuterId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public string DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
   
}