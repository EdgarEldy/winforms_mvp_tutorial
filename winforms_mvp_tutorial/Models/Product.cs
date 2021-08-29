using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_mvp_tutorial.Models
{
    [Table("products")]
    class Product
    {
        // Constructor
        public Product()
        {

        }

        // Properties
        public int Id { get; set; }

        public int? CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual Category Category { get; set; }
    }
}
