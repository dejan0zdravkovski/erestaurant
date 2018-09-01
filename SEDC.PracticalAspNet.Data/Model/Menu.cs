using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PracticalAspNet.Data.Model
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte TypeId { get; set; }

        [Required]
        [MaxLength(200)]
        public string RestaurantName { get; set; }

        public List<Category> ListCategories { get; set; }
    }
}
