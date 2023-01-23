using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public long ModifiedTicks { get; set; }
    }
}
