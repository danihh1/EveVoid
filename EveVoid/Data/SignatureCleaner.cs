using DotNetty.Common;
using DotNetty.Common.Concurrency;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace EveVoid.Data
{
    public class SignatureCleaner : IHostedService, IDisposable
    {
        private readonly ILogger<SignatureCleaner> _logger;
        private int executionCount = 0;
        private Timer _timer;
        private readonly IServiceScopeFactory scopeFactory;


        public SignatureCleaner(IServiceScopeFactory scopeFactory, ILogger<SignatureCleaner> logger)
        {
            this.scopeFactory = scopeFactory;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromMinutes(5));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);

            using (var scope = scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<EveVoidContext>();
                var fourHoursAgo = DateTime.UtcNow.AddHours(-4);
                var expiredSignatures = context.Signatures.Where(x => x.ExpiryDate <= fourHoursAgo);
                foreach (var sig in expiredSignatures)
                {
                    if (sig.Destination != null)
                    {
                        sig.Destination.DestinationId = null;
                    }
                    sig.DestinationId = null;
                }
                context.UpdateRange(expiredSignatures);
                context.SaveChanges();
                context.Signatures.RemoveRange(expiredSignatures);
                context.SaveChanges();

                var now = DateTime.UtcNow;
                var expiredTags = context.SolarSystemTags.Where(x => x.ExpiryDate <= now);
                context.SolarSystemTags.RemoveRange(expiredTags);
                context.SaveChanges();
            }
            
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
