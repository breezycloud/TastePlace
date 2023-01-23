using TastePlace.Shared.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastePlace.Shared.Services
{
    public class BackgroundTasks : BackgroundService, IDisposable
    {
        private readonly ILogger<BackgroundTasks> _logger;
        private readonly IHubContext<AppHub> _hubContext;
        private readonly PeriodicTimer _timer = new(TimeSpan.FromMinutes(5));

        public BackgroundTasks(IHubContext<AppHub> hubContext, ILogger<BackgroundTasks> logger)
        {
            _hubContext = hubContext;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (await _timer.WaitForNextTickAsync(stoppingToken))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await _hubContext.Clients.All.SendAsync("Download", stoppingToken);
            }
        }

        void IDisposable.Dispose()
        {
            _timer.Dispose();
        }
    }
}
