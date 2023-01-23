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
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        public PaymentMode? PaymentMode { get; set; }
        public bool IsDeleted { get; set; } = false;
        public long ModifiedTicks { get; set; } = DateTime.Now.Ticks;
        [ForeignKey(nameof(OrderId))]
        public Order? Order { get; set; }
    }
}
