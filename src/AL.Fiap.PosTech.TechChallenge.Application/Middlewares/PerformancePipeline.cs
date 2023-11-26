using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AL.Fiap.PosTech.TechChallenge.Application.Middlewares
{
    public sealed class PerformancePipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
    {
        private readonly Stopwatch _timer;
        private readonly ILogger<TRequest> _logger;

        public PerformancePipeline(ILogger<TRequest> logger)
        {
            _timer = new Stopwatch();
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            string requestName = typeof(TRequest).Name;

            _timer.Start();
            _logger.LogInformation($"{DateTime.Now} - Start Request: {requestName}. {request}!");

            var response = await next();

            if (_timer.Elapsed.TotalMilliseconds < 100)
            {
                _timer.Stop();
                _logger.LogInformation($"{DateTime.Now} - End Request: {requestName}. seconds: {_timer.Elapsed.TotalSeconds:n7}. {request}!");
            }
            else
            {
                _timer.Stop();
                _logger.LogWarning($"{DateTime.Now} - End Long Execution Request: {requestName}. seconds: {_timer.Elapsed.TotalSeconds:n7}. {request}!");
            }

            return response;
        }
    }
}