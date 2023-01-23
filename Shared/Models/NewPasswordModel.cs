using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class NewPasswordModel
    {
        [Required(ErrorMessage = "Old password is required")]
        public string? OldPasswprd { get; set; }
        public string? HashedPassword { get; set; }
        [Required(ErrorMessage = "New password is required")]
        public string? NewPassword { get; set; }
    }
}
