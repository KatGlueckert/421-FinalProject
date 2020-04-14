using System;
using System.ComponentModel.DataAnnotations;

namespace Uplift.DataAccess.Data
{
    public class Users
    {
        [Key]
        [Required]
        public string email { get; set; }

        [Required]
        public string fName { get; set; }

        [Required]
        public string lName { get; set; }

        [Required]
        public string phoneNumber { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
