using Darvyn_Lavandier_P1_AP1.Components;
using Microsoft.EntityFrameworkCore;
using DarvynLuisLavandier_P1_AP1.DAL;
using DarvynLuisLavandier_P1_AP1.Service;

namespace Darvyn_Lavandier_P1_AP1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();
            //Obtenemos el ConStr para usarlo en el contexto
            var ConStr = builder.Configuration.GetConnectionString("SqlConStr");


            //Agregamos el contexto al builder con el ConStr
            builder.Services.AddDbContextFactory<Contexto>(o => o.UseSqlServer(ConStr));

            //Inyeccion del service
            builder.Services.AddScoped<RegistroService>();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
