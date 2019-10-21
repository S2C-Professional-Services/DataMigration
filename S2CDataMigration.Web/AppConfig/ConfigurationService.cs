using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Rx.Core.Data;
using Rx.Core.Security;
using Rx.Core.Security.Filters;
using S2CDataMigration.Models;
using S2CDataMigration.Web.Domain;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace S2CDataMigration.Web
{
    public class ConfigurationService
    {
        public static void Register(IServiceCollection services, IConfiguration configuration, string path)
        {
            SetCQRSPolicy(services);
            SetGzipCompression(services);
            AddDbContext(services);

            RegisterCoreServices(services, configuration);
            RegisterUnitOfWorkServices(services, configuration);
            
        }

        private static void RegisterApplicationService(IServiceCollection services)
        {
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IPracticeService, PracticeService>();
            
        }

        
        private static void RegisterCoreServices(IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IConfiguration>(_ => configuration);
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IPrincipal>(provider => provider.GetService<IHttpContextAccessor>().HttpContext.User);

            services.AddScoped<IRepositoryProvider, RepositoryProvider>();
            //services.AddTransient<IJwtTokenProvider, JwtTokenProvider>();
            //services.AddTransient<ITokenValidator, JwtTokenProvider>();
            //services.AddScoped<IRequestAccessor, RequestAccessor>();
            services.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));
            services.AddMemoryCache();
            services.AddScoped<IGentuContext, gentuContext>();
            RegisterApplicationService(services);


        }
        private static void RegisterUnitOfWorkServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IGentuUow, GentuUow>();
        }


        static void AddDbContext(IServiceCollection services)
        {
            services.AddDbContext<gentuContext>();
        }
        private static void SetCQRSPolicy(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
        }
        private static void SetGzipCompression(IServiceCollection services)
        {
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
            });
        }

        static void AddMvcOptions(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddMvc(options =>
            {
                //var logSqlDbContext = services.BuildServiceProvider().GetService<LogSqlDbContext>();
                //var applicationCache = services.BuildServiceProvider().GetService<IApplicationCache>();
                //var serverSetting = services.BuildServiceProvider().GetService<ServerSetting>();
                options.InputFormatters.Insert(0, new ApplicationInputFormatter());
                options.Filters.Add(new ModelValidation());
               // options.Filters.Add(new LogRequest(logSqlDbContext));
               // //options.Filters.Add(new ApplicationETag(applicationCache,serverSetting));
            }).AddDataAnnotationsLocalization().AddJsonOptions(
                oo =>
                {
                    var resolver = new CamelCasePropertyNamesContractResolver();
                    if (resolver != null)
                    {
                        var res = resolver as DefaultContractResolver;
                        res.NamingStrategy = null;
                    }
                    oo.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
        }
    }
}
