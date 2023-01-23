using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class MenuItem
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SubGroupId { get; set; }
        public Guid CategoryId { get; set; }       
        public string? Code { get; set; }
        public string? Alias { get; set; }
        [Required]
        public string? MenuName { get; set; }
        public ServeUnit ServeUnit { get; set; }
        [Column(TypeName= "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal VAT { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tax2 { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public long ModifiedTicks { get; set; }

        [ForeignKey(nameof(SubGroupId))]
        public virtual MenuSubGroup? SubGroup { get; set; }
        
        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }
    }

}
