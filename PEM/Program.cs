using PEM.Service.Helpers.Clients;
using PEM.Service.Helpers.POCO;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    // Set a 2 minutes of Inactivity Session timeout.
    options.IdleTimeout = TimeSpan.FromSeconds(30000);
    options.Cookie.HttpOnly = true;
    // Make the session cookie essential
    options.Cookie.IsEssential = true;
});

//services.AddDevExpressControls();
builder.Services.AddMvc();
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

//var mappingConfig = new MapperConfiguration(mc =>
//{
//    //mc.AddProfile(new MappingProfile());
//});

//IMapper mapper = mappingConfig.CreateMapper();

//builder.Services.AddMvc().AddJsonOptions(options => options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<IPowersoftApiProvider, PowersoftApiProvider>();
//services.AddScoped<Session>();

//retrieve settings from appsettings.json
var applicationSettingsSection = builder.Configuration.GetSection("APIsettings");
var val = builder.Services.Configure<APIsettings>(applicationSettingsSection);
builder.Services.AddHttpClient("PEApi",
    s =>
    {
        s.BaseAddress = new Uri(builder.Configuration.GetValue<string>("APIsettings:WebApiBaseUrl"));
    }
    );

var applicationSettingsSection1 = builder.Configuration.GetSection("SessionTimeout");
builder.Services.Configure<SessionTimeout>(applicationSettingsSection1);


//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCookiePolicy();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Index}");
/*    pattern: "{controller=Account}/{action=Login}/{id?}");
*/
app.Run();
