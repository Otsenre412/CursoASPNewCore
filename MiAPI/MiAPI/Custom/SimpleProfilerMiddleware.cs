using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MiAPI.Custom
{
    public class SimpleProfilerMiddleware
    {
        private RequestDelegate _next;
        private ILoggerfactory _logger;

        public SimpleProfilerMiddleware(RequestDelegate next, ILoggerfactory loggerfactory)
        {
            _next = next;
            _logger = loggerfactory.CreateLogger("Profiler");
        }

        public async Task Invoke(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            await _next(context);
            var path = context.Request.Path;
            var statusCode = context.Response.StatusCode;
            var logString = $"Path = '(path)', status = (statusCode), time = (watch.Elapsed)";

            _logger.LogInformation(logString);
        }
    }
}
