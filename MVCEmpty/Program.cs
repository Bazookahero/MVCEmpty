using MVCEmpty.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVCEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            var app = builder.Build();
            
            if (app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                app.UseHttpsRedirection();

                //app.UseDefaultFiles();// css i wwwroot
                app.UseStaticFiles();// html i wwwroot

                app.UseSession();

                app.UseRouting();

                app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    //endpoints act like a if/else chain, first one that is true is the one to be used!
                    //endpoints.MapControllerRoute(
                    //    name: "doctor",
                    //    pattern: "{controller=Doctor}/{action=DoctorPage}/{id?}"
                    //    );
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=HomeIndex}/{id?}"
                        );

                });
                
                app.Run();
            }

        }
    }
}