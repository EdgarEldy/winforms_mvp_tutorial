using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_mvp_tutorial.Models
{
    [Table("users")]
    class User
    {
        // Constructor
        public User()
        {

        }

        // Properties
        public int Id { get; set; }

        public int RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string FistName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
