using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Inlämmningsuppgift_1
{
    public class Worker : BackgroundService
    {


        private readonly ILogger<Worker> _logger;
        public Random random = new Random();
        
            public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            
            
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var temp = random.Next(10,50);
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
