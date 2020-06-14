using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .AddCommandLine(args)
                 .Build();
            CreateHostBuilder(config).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(IConfiguration configuration)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseConfiguration(configuration);
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}