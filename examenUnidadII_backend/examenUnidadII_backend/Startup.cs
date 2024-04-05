using examenUnidadII_backend.Database;
using Microsoft.EntityFrameworkCore;

namespace examenUnidadII_backend
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(
            IConfiguration configuration
            )
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Add DbContext
            services.AddDbContext<ImcListDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endopoints =>
            {
                endopoints.MapControllers();
            });

        }
    }
}
