using DotNetty.Common;
using DotNetty.Common.Concurrency;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private int executionCount = 0;
        private Timer _timer;
        private readonly IServiceScopeFactory scopeFactory;


        public SignatureCleaner(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Info("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromMinutes(5));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.Info(
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
            }
            
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Info("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
