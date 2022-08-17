using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_mvp_tutorial.Models
{
    [Table("Categories")]
    class Category
    {
        // Constructor
        public Category()
        {
            Products = new HashSet<Product>();
        }

        // Properties
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
