using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers;
using Framework.DependencyResolvers;
using Framework.Extensions;
using Framework.Utilities.IoC;
using Framework.Utilities.Security.Encryption;
using Framework.Utilities.Security.JWT;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Persistence.Concrete.EntityFramework.Contexts;
using Persistence.Concrete.EntityFramework.Seeding;
using System.Text.Json;
using Microsoft.OData.ModelBuilder;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.OData;


var builder = WebApplication.CreateBuilder(args);
var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();
// Add services to the container.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(configuration =>
{
    configuration.RegisterModule(new AutofacBusinessModule());
}));
builder.Services.AddTransient<MiniStadiumRentDbContext>();
builder.Services.AddDbContext<MiniStadiumRentDbContext>();
builder.Services
    .AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles)
    .AddOData(options =>
    {
        options.EnableQueryFeatures();
    });

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddCors();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{ 
    //DbSeed.Init();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(builder =>
{
    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
});
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
