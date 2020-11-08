using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestAssignment.Interface;
using TestAssignment.ResultClasses;


namespace TestAssignment
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvcCore().AddRazorViewEngine();
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:5001")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            
            services.AddScoped<IResult, ResultIfTwo>();
            services.AddScoped<IResult, ResultIfThree>();
            services.AddScoped<IResult, ResultIfFour>();
            services.AddScoped<IResult, ResultIfFive>();
            services.AddScoped<IResult, ResultIfSix>();
            services.AddScoped<IResult, ResultIfSeven>();
            services.AddScoped<IResult, ResultIfEight>();
            services.AddScoped<IResult, ResultIfNine>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseStaticFiles();
        }
    }
}