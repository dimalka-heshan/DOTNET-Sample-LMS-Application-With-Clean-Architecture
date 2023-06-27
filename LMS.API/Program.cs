using LMS.Application;
using LMS.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Serilog;

namespace LMS.API
{
    public class Program
    {
      public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(builder.Configuration);

            builder.Services.Configure<RouteOptions>(options =>
            {
                options.ConstraintMap.Add("apiVersion", typeof(ApiVersionRouteConstraint));
            });
            builder.Host.UseSerilog((context, configuration) =>
                 configuration.ReadFrom.Configuration(context.Configuration));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }



    }
}


