using System;
using System.ComponentModel.DataAnnotations;

namespace Uplift.DataAccess.Data
{
    public class Items
    {
        [Key]
        [Required]
        public Guid itemID { get; set; }

        [Required]
        public string itemDescription { get; set; }

        [Required]
        public DateTime dateSold { get; set; }

        public int itemsSold {get; set;}
    }
}