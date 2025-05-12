using MediatR;
using Serilog;
using Serilog.Core;
using System.Globalization;

namespace Inventa.Product.Application.Common.Behaviors
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;

            var logDirectory = Path.Combine("../../Logs", "Log-" + DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            Directory.CreateDirectory(logDirectory);

            var logFileName = Path.Combine(logDirectory, $"log-{DateTime.Now.ToString("HH-mm-ss-fff")}.txt");

            using Logger logger = new LoggerConfiguration()
                .WriteTo.File(logFileName)
                .Enrich.FromLogContext()
                .MinimumLevel.Information()
                .CreateLogger();

            logger.Information("Handling {RequestName} with request: {@Request}", requestName, request);

            var response = await next();

            logger.Information("Handled {RequestName} with response: {@Response}", requestName, response);

            return response;
        }
    }
}
