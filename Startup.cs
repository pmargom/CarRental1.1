using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental1._1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Indicamos que queremos usar las dependencias necesarias para hacer uso del framework MVC
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app) {

            // Aquí se incluirán los uso de los diferentes middleware's que vaya
            // necesitando nuestra aplicación
            // El siguiente middleware es para indicar el tipo de rutas que se permitirán
            // en los endpoints del api
            app.UseMvc();

        }
    }
}
