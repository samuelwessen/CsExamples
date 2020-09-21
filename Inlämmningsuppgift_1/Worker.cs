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

        public override Task StartAsync(CancellationToken cancellationToken)
        {            
            _logger.LogInformation("The service has been started.");

            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The service has been stopped.");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var temp = random.Next(10,40);

                if (temp < 20)
                    _logger.LogInformation($"Temperature is {temp}c, everything is fine");
                else 
                _logger.LogInformation($"Warning, temperature {temp}c is above 20c, take cover");


                await Task.Delay(60 * 1000, stoppingToken);
            }
        }
    }
}
