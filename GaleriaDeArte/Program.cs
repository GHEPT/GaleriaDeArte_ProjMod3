using GaleriaDeArte.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace GaleriaDeArte
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = CreateHostBuilder(args).Build();

            SeedDatabase.initialize(app); // Eu n�o preciso instanciar, porque � uma classe est�tica, com m�todos est�ticos.

            app.Run();
        }

            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });
        
    }
}
