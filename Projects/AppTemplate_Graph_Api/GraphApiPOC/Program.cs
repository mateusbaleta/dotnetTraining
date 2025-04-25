using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using GraphApiTemplate.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Set fake env vars for Graph SDK
Environment.SetEnvironmentVariable("CLIENT_ID", "fake-client-id");
Environment.SetEnvironmentVariable("TENANT_ID", "fake-tenant-id");
Environment.SetEnvironmentVariable("CLIENT_SECRET", "fake-client-secret");

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<GraphService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();