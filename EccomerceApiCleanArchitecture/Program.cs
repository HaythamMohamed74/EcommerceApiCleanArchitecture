
using EccomerceApiCleanArchitecture.Core;
using EccomerceApiCleanArchitecture.Infrastructure;
using EccomerceApiCleanArchitecture.Infrastructure.Context;
using EccomerceApiCleanArchitecture.Service;
using Microsoft.EntityFrameworkCore;

namespace EccomerceApiCleanArchitecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            #region Connection

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            #endregion
            #region CORS
            builder.Services.AddCors(c =>
            {
                c.AddDefaultPolicy( options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            #endregion
            builder.Services.AddInfastuctureDependencies();
            builder.Services.AddServiceDependencies();
            builder.Services.AddCoreDependencies();

            //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));



            //builder.Services.AddScoped<IProductRepository,ProductRepository >();
            //builder.Services.AddScoped<IProductService,ProductService>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
