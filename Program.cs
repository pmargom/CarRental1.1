using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CarRental1._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseKestrel()                       // web server cross-platform incluido por defecto al usar dotnet new
                .UseStartup<Startup>();             // indicamos la clase que se usará como punto de entrada
            
            // la siguiente instrucción es opcional, es solo cambiar la ruta por defecto
            // la ruta por defecto es: http://localhost:5000"
            builder.UseUrls("http://localhost:8000");

            // la siguiente instrucción es opcional. Sirve para cambiar el numero de threads o procesos
            // que atenderán las peticiones. Permite destinar más recursos de CPU para anteder peticiones HTTP
            builder.UseKestrel(options => {
                options.ThreadCount = 4;
            });

            var host = builder.Build();
            host.Run();
        }
    }
}
