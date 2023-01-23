using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class MenuSubGroup
    {
        [Key]
        public Guid Id { get; set; }
        public Guid MenuGrpId { get; set; }
        [Required]
        public string? MenuSubGrp { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public long ModifiedTicks { get; set; } = DateTime.Now.Ticks;
        [ForeignKey(nameof(MenuGrpId))]
        public virtual MenuGroup? MenuGroup { get; set; }
    }
}
