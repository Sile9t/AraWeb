using AraWeb.Extensions;
using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NLog;
using AraWeb.ActionFilters;
using Service.Contracts;
using Service;
using Shared.Dtos;
using Contracts.Links;
using AraWeb.Utility;
using ActionFilter;

namespace AraWeb
{
    public class Program
    {
        private static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter() =>
            new ServiceCollection().AddLogging().AddMvc().AddNewtonsoftJson()
            .Services.BuildServiceProvider()
            .GetRequiredService<IOptions<MvcOptions>>().Value.InputFormatters
            .OfType<NewtonsoftJsonPatchInputFormatter>().First();

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

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.ConfigureRepositoryManager();
            builder.Services.ConfigureServiceManager();

            builder.Services.AddControllers(config =>
            {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
                config.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
            })
                .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);

            builder.Services.AddScoped<IDataShaper<ApartmentDto>, DataShaper<ApartmentDto>>();
            builder.Services.AddScoped<IApartmentLinks, ApartmentLinks>();

            builder.Services.AddCustomMediaTypes();

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            builder.Services.AddScoped<AsyncValidationFilterAttribute>();
            builder.Services.AddScoped<ValidateMediaTypeAttribute>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Ara Web", 
                    Version = "v1" });
            });

            builder.Services.AddAuthentication();
            builder.Services.ConfigureIdentity();
            builder.Services.ConfigureJWT(builder.Configuration);

            var app = builder.Build();

            var logger = app.Services.GetRequiredService<ILoggerManager>();
            app.ConfigureExceptionHandler(logger);

            // Configure the HTTP request pipeline.

            //Note: Exception handler wouldn't work with swagger.
            if (app.Environment.IsDevelopment() & false)
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(s =>
                {
                    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Ara Web");
                });
            }
            if (app.Environment.IsProduction()) app.UseHsts();

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseCors("CorsPolicy");

            app.UseAuthorization();
            app.UseAuthentication();

            app.MapControllers();

            app.Run();
        }
    }
}
