using PEM.Service.Helpers.POCO;

namespace PEM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                // Set a 2 minutes of Inactivity Session timeout.
                options.IdleTimeout = TimeSpan.FromSeconds(30000);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            //services.AddDevExpressControls();
            services.AddMvc();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddRazorPages().AddRazorRuntimeCompilation();
            //var mappingConfig = new MapperConfiguration(mc =>
            //{
            //    //mc.AddProfile(new MappingProfile());
            //});

            //IMapper mapper = mappingConfig.CreateMapper();

            //services.AddMvc().AddJsonOptions(options => options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped<Session>();

            //retrieve settings from appsettings.json
            var applicationSettingsSection = Configuration.GetSection("APIsettings");
            var val = services.Configure<APIsettings>(applicationSettingsSection);
            services.AddHttpClient("PEApi",
                s =>
                {
                    s.BaseAddress = new Uri(Configuration.GetValue<string>("APIsettings:WebApiBaseUrl"));
                }
                );

            var applicationSettingsSection1 = Configuration.GetSection("SessionTimeout");
            services.Configure<SessionTimeout>(applicationSettingsSection1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
