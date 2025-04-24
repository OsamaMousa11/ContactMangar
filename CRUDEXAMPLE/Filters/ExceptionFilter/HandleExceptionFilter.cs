using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CRUDPROJECT.Filters.ExceptionFilter
{
    public class HandleExceptionFilter : IExceptionFilter
    {   private readonly ILogger<HandleExceptionFilter> _logger;

        public HandleExceptionFilter(ILogger<HandleExceptionFilter> logger)
        {
            _logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            _logger.LogError("Exception filter {FilterName}.{MethodName}\n{ExceptionType\n}{ExceprionMessage\n}",
                nameof(HandleExceptionFilter),nameof(OnException),context.Exception.GetType()
                .ToString(),context.Exception.Message);
            context.Result = new ContentResult()
            {
                Content = context.Exception.Message,
                StatusCode = 500
            };
        }
    }
}

