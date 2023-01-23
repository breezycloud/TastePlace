using Microsoft.AspNetCore.ResponseCompression;
using System.Text;
using System;
using TastePlace.Shared.Context;
using Microsoft.EntityFrameworkCore;
using TastePlace.Shared.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using TastePlace.Shared.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var key = Encoding.ASCII.GetBytes(builder!.Configuration["App:Key"]!);
builder.Services.AddControllersWithViews();
builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddSignalR();
builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});
builder.Services.AddRazorPages();


string ConnectionString = string.Empty;
#if DEBUG
    ConnectionString = builder.Configuration.GetConnectionString("Sqlite")!;
    builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(ConnectionString));
#else
    ConnectionString = builder.Configuration.GetConnectionString("Production");
    builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
#endif

builder.Services.AddScoped<AppDbContext>();

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(ConnectionString));

builder.Services.AddHostedService<BackgroundTasks>();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = true;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
    };
});

var app = builder.Build();
SeedData.EnsureSeeded(app.Services);


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();
app.MapHub<AppHub>("/hubs");
app.MapFallbackToFile("index.html");

app.Run();