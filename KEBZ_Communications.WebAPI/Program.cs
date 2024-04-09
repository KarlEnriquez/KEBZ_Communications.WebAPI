using KEBZ_Communications.WebAPI.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;
using Contracts;
using KEBZ_Communications.WebAPI;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// CORS policy is 'disabled' at the moment.
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration(); // Does nothing at the moment.
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
//builder.Services.Configure<ApiBehaviorOptions>(options =>
//{
//    options.SuppressModelStateInvalidFilter = true; // Doesn't automatically return 400 response
//});
builder.Services.AddControllers(config =>
{
    config.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
});

var app = builder.Build();
app.UseExceptionHandler(opt => { });

// Configure the HTTP request pipeline.


if (app.Environment.IsProduction())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

// Allows using static files in the the request, defaults to wwwroot
app.UseStaticFiles();

// Forward proxy headers to the current request.
// This is used when the app is hosted behind a reverse proxy server.
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
{
    return new ServiceCollection()
        .AddLogging()
        .AddMvc()
        .AddNewtonsoftJson()
        .Services
        .BuildServiceProvider()
        .GetRequiredService<IOptions<MvcOptions>>()
        .Value
        .InputFormatters
        .OfType<NewtonsoftJsonPatchInputFormatter>()
        .First();
}