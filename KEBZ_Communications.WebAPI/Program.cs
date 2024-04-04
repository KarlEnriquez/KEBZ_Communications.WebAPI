using KEBZ_Communications.WebAPI.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

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

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.


if (app.Environment.IsDevelopment())
{
    // Shows detailed error information during development.
    app.UseDeveloperExceptionPage();
} 
else
{
    // Hides detailed error information in production.
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
