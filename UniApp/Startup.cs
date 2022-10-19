using UniApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestModels.ConferencePlanner;

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
      services.AddSingleton<IRepository, Repository>();
      services.AddControllers();
      services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
   }

   public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
   {
      if (env.IsDevelopment())
      {
         app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();
      app.UseRouting();
      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
         endpoints.MapControllers();
      });
   }
}