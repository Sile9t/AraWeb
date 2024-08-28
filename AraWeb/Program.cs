using AraWeb.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using NLog;

namespace AraWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
                "/nlog.config"));

            builder.Services.ConfigureCors();
            builder.Services.ConfigureIISIntegration();
            builder.Services.ConfigureLoggerService();

            builder.Services.ConfigureSqlContext(builder.Configuration);

            builder.Services.ConfigureRepositoryManager();
            builder.Services.ConfigureServiceManager();

            builder.Services.AddControllers()
                .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Ara Web", Version = "v1" });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(s =>
                {
                    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Ara Web");
                });
            }
            else app.UseHsts();

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseCors("CorsPolicy");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
