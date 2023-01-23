using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class GroupSubCategoryMenu
    {
        public Guid Id { get; set; }
        public string? Group { get; set; }
        public string? SubGroup { get; set; }
        public string? Category { get; set; }
        public string? Code { get; set; }
        public string? Menu { get; set; }
        public string? ServeUnit { get; set; }
        public decimal Price { get; set; }
    }
}
