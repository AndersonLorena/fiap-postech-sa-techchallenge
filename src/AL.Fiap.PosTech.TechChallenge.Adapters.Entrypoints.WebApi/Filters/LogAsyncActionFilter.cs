using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Filters
{
    public sealed class LogAsyncActionFilter : IAsyncActionFilter
    {
        private readonly Stopwatch _timer;

        public LogAsyncActionFilter()
        {
            _timer = new Stopwatch();
        }

        public async Task OnActionExecutionAsync(
            ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // Do something before the action executes.
            _timer.Start();

            var executedContext = await next();

            // Do something after the action executes.
            _timer.Stop();
            executedContext.HttpContext.Response.Headers.Add("X-Execution-Time", $"{_timer.Elapsed.TotalSeconds:n7}");
        }
    }
}