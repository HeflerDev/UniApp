using UniApp.Models;
using Microsoft.EntityFrameworkCore;

namespace UniApp;

public class Startup
{
   public Startup(IConfiguration configuration)
   {
      Configuration = configuration;
   }
   
   public IConfiguration Configuration { get; }

   public void ConfigureServices(IServiceCollection services)
   {
      services.AddControllers(opts => opts.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
      services.AddDbContext<ApplicationDbContext>(options =>
         options.UseSqlServer(Configuration.GetConnectionString("UniConnection")));
      services.AddEndpointsApiExplorer();
      services.AddSwaggerGen();
   }

   public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
   {
      if (env.IsDevelopment())
      {
         app.UseDeveloperExceptionPage();
      }

      app.UseSwagger();
      app.UseSwaggerUI();
      app.UseHttpsRedirection();
      app.UseRouting();
      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
         endpoints.MapControllers();
      });
   }
}