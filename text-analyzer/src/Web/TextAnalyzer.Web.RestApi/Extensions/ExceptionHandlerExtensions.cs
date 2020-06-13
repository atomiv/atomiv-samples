using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Atomiv.Core.Application;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Web.AspNetCore;
using System;
using System.Net;

namespace TextAnalyzer.Web.RestApi.Extensions
{
    public static class ExceptionHandlerExtensions
    {
        private static IExceptionProblemDetailsFactory GetDefaultProblemDetailsFactory()
        {
            var registry = new ExceptionProblemDetailsFactoryRegistry(new SystemExceptionProblemDetailsFactory());

            registry.Add(new BadHttpRequestExceptionProblemDetailsFactory());
            registry.Add(new RequestValidationExceptionProblemDetailsFactory());

            return new ExceptionProblemDetailsFactory(registry);
        }

        public static IApplicationBuilder UseProblemDetailsExceptionHandler(this IApplicationBuilder app, IExceptionProblemDetailsFactory problemDetailsFactory = null)
        {
            app.UseExceptionHandler(configure =>
            {
                configure.Run(async context =>
                {
                    try
                    {
                        var jsonSerializationService = app.ApplicationServices.GetRequiredService<IJsonSerializer>();

                        if (problemDetailsFactory == null)
                        {
                            problemDetailsFactory = GetDefaultProblemDetailsFactory();
                        }

                        var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();
                        var exception = exceptionHandlerFeature.Error;

                        // Unauthorized

                        if (exception.GetType() == typeof(AuthorizationException))
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                            return;
                        }

                        // NotFound

                        if (exception.GetType() == typeof(ExistenceException))
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                            return;
                        }

                        // UnprocessableEntity

                        var problemDetails = problemDetailsFactory.Create(exception);

                        if (problemDetails != null)
                        {
                            var instance = problemDetails.Instance;

                            context.Response.StatusCode = problemDetails.Status.Value;

                            await context.Response.WriteJsonAsync(problemDetails, jsonSerializationService);
                        }
                    }
                    catch (Exception)
                    {
                        // TODO: VC: Attempt log
                        throw;
                    }
                });
            });

            return app;
        }
    }
}
