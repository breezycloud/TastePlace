using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class DashboardModel
    {
        public int TotalBranches { get; set; }
        public int Categories { get; set; }
        public int TotalCustomers { get; set; }
        public int AvailableProducts { get; set; }
        public int SoldProducts { get; set; }
        public int TotalEmployees { get; set; }
        public ItemChartModel[] Items { get; set; } = Array.Empty<ItemChartModel>();
        public ItemSalesLine[] ItemSales { get; set; } = Array.Empty<ItemSalesLine>();
    }
    public class ItemSalesLine
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int? Sales { get; set; }
    }
}
