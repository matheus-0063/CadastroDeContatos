using CadastroDeContatos.Data;
using CadastroDeContatos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeContatos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Conexão com o Banco de Dados
            var connectionString = builder.Configuration.GetConnectionString("DataBase");
            builder.Services.AddDbContext<BancoContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
            

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}