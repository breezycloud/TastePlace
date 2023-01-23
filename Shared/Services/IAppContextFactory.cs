using TastePlace.Shared.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Services
{
    public interface IAppContextFactory
    {
        Task<AppDbContext> CreateDbContextAsync();
    }
}
