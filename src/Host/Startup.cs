using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.ApiWidgets;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Host
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            var options = new RequestFilteringOptions()
                .AddFileExtensionRequestFilter(new FileExtensionsOptions {
                    FileExtensions = new List<FileExtension>
                    {
                        new FileExtension { Extension = ".jpg", Allowed = true },
                        new FileExtension { Extension = ".psd", Allowed = false }
                    }
                })
                .AddHttpMethodRequestFilter(new HttpMethodOptions {
                    AllowUnlisted = false,
                    HttpMethods = new List<HttpMethod>
                    {
                        new HttpMethod() { Verb = "Get", Allowed = true }
                    }
                })
                .AddQueryStringRequestFilter(new QueryStringsOptions {
                    AllowUnlisted = false,
                    QueryStrings = new List<QueryStringElement>
                    {
                        new QueryStringElement { QueryString = "id", Allowed = true },
                        new QueryStringElement { QueryString = "name", Allowed = false }
                    }
                })
                .AddHiddenSegmentRequestFilter(new HiddenSegmentsOptions {
                    HiddenSegments = new List<string>
                    {
                        "Private"
                    }
                })
                .AddHeaderRequestFilter(new HeadersOptions {
                    Headers = new List<HeaderElement>
                    {
                        new HeaderElement() { Header = "X-Auth", SizeLimit = 5 }
                    }
                })
                .AddUrlRequestFilter(new UrlsOptions {
                    DeniedUrlSequences = new[] { "me" },
                    AllowedUrls = new[] { "/Home" }
                })
                .AddIPAddressRequestFilter(new IPAddressOptions {
                    IPAddresses = new[] { "::1" }
                });

            app.UseRequestFiltering(options);

            app.UseMvc();
        }
    }
}
