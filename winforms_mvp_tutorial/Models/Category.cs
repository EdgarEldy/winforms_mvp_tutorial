using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_mvp_tutorial.Models
{
    [Table("categories")]
    class Category
    {
        // Constructor
        public Category()
        {

        }

        // Properties
        public int Id { get; set; }

        public string CategoryName { get; set; }
    }
}
