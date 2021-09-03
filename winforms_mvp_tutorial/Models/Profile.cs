using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_mvp_tutorial.Models
{
    [Table("profiles")]
    class Profile
    {
        // Constructor
        public Profile()
        {

        }

        // Properties
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProfileName { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
