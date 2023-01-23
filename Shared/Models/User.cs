using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastePlace.Shared.Enums;

namespace TastePlace.Shared.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "First Name is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }
        [NotMapped]
        public string? FullName => FirstName + ' ' + LastName;
        [StringLength(14, ErrorMessage = "Phone No is should 10 characters", MinimumLength = 10)]
        public string? MobileNo1 { get; set; }
        [RegularExpression("^[A-Za-z0-9_\\+-]+(\\.[A-Za-z0-9_\\+-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*\\.([A-Za-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }
        public string? HashedPassword { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageFormat { get; set; }
        public UserRole Role { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public long ModifiedTicks { get; set; }
        [NotMapped]
        public string? Token { get; set; }
    }
}
