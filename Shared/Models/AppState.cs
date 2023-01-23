using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Models
{
    public class AppState
    {
        public MenuItem[] Items { get; set; } = Array.Empty<MenuItem>();
        public Order? Order { get; set; }
        public Customer? Customer { get; set; }
        public Customer[]? Customers { get; set; }
        public Category? Category { get; set; }
        public Category[] Categories { get; set; } = Array.Empty<Category>();
        public Payment Payment { get; set; } = default!;
        public GroupSubCategoryMenu[] Menus { get; set; } = Array.Empty<GroupSubCategoryMenu>();
        public string? searchString = "";
        public bool IsProcessing { get; set; }
        public bool IsBusy { get; set; }
        public bool IsConnected { get; set; }
        public bool IsUpload { get; set; }
        public bool IsDownload { get; set; }
        public string? Token { get; set; }

    }
}
