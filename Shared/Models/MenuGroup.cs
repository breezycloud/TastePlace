using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class MenuGroup
    {
        [Key]
        public Guid Id { get; set; }
        public string? MenuGrp { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public long ModifiedTicks { get; set; }
        public virtual List<MenuSubGroup>? MenuSubGroups { get; set; } = default!;
    }
}
