using System;
using System.ComponentModel.DataAnnotations;

namespace Uplift.DataAccess.Data
{
    public class Item
    {

        // Perhaps we should add "title" "price" and "deleted" attributes?
        // Also, I don't think itemDescription should be required.

        [Key]
        [Required]
        public Guid ItemID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public string ItemDescription { get; set; }

        public DateTime DateSold { get; set; }

        public int ItemsSold {get; set;}
    }
}