using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApi.Db;
using WebApi.Settings;

namespace WebApi.Services {
    public class MainService : IHostedService {
        private readonly AppSettings _settings;
        private readonly ILogger<MainService> _logger;

        public MainService(AppSettings settings, ILogger<MainService> logger) {
            _logger = logger;
            _settings = settings;
        }

        public Task StartAsync(CancellationToken cancellationToken) {

            var options = new DbContextOptionsBuilder()
                .UseNpgsql(_settings.ConnectionString)
                .Options;

            using (var context = new MyContext(options)) {
                _logger.LogInformation("create database - {0}", options);
                context.Database.EnsureCreated();
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) {
            return Task.CompletedTask;
        }
    }
}
