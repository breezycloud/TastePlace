using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class Customer : User
    {
        public string? ContactAddress { get; set; }
        public string? ShippingAddress { get; set; }
    }
}
