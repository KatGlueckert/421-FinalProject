using System;
using System.ComponentModel.DataAnnotations;

namespace Uplift.DataAccess.Data
{
    public class Pizza
    {
        [Key]
        [Required]
        public Guid ID { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }
    }
}