using Microsoft.OpenApi.Models;

namespace Sisreq.Courses.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Courses API", Version = "v1" });
            });
            services.AddControllers();
        }
    }
}