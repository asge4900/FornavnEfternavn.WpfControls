using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Dna;
using Dna.AspNet;
using Microsoft.AspNetCore;

namespace FornavnEfternavn.WpfControls.Web.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                // Add Dna Framework
                .UseDnaFramework(construct =>
                {
                    // Configure framework

                    // Add file logger
                    construct.AddFileLogger();
                })
                .UseStartup<Startup>();
    }
}
