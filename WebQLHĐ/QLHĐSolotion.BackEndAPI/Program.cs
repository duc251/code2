using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

using Microsoft.OpenApi.Models;
using QLHĐSolotion.Application.CongNo;
using QLHĐSolotion.Application.Doitac;
using QLHĐSolotion.Application.HopDong;
using QLHĐSolotion.Application.KhachHang;
using QLHĐSolotion.Data.EF;
using QLHĐSolotion.Data.Extensions;
using QLHĐSolotion.ViewModel.Doitac.Dtos;

using System.Net.Http.Json; //this is needed for PostAsJsonAsync to work
using System.Configuration;
using Newtonsoft.Json.Serialization;
using QLHĐSolotion.Application.FileHopdong;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("eShopSolutionDb")));


//options.UseSqlServer("eShopSolutionDb");SystemConstants.MainConnectionString

//Declare DI
builder.Services.AddTransient<IPublicKhachHangServicer, PublicKhachHangService>();
builder.Services.AddTransient<IPublicDoiTacServicer, PublicDoiTacService>();
builder.Services.AddTransient<IPublicCongNoServicer, PublicCongNoService>();
builder.Services.AddTransient<IPublicHopDongServicer, PublicHopDongServicer>();
builder.Services.AddTransient<IPulicFileHopDong, PublicFileHopDong>();
//builder.Services.AddTransient<IDoitacService, DoiTacService>();
builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger QLHĐ Solution", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });
});
//string issuer = builder.Configuration.GetValue<string>("Tokens:Issuer");
//string signingKey = builder.Configuration.GetValue<string>("Tokens:Key");
//byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);
//builder.Services.AddAuthentication(opt =>
//{
//    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//    .AddJwtBearer(options =>
//    {
//        options.RequireHttpsMetadata = false;
//        options.SaveToken = true;
//        options.TokenValidationParameters = new TokenValidationParameters()
//        {
//            ValidateIssuer = true,
//            ValidIssuer = issuer,
//            ValidateAudience = true,
//            ValidAudience = issuer,
//            ValidateLifetime = true,
//            ValidateIssuerSigningKey = true,
//            ClockSkew = System.TimeSpan.Zero,
//            IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
//        };
//    });
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
//builder.Services.AddCors();


builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
});
//jQuery.support.cors = true;


HttpClient client = new HttpClient();
HttpResponseMessage response = await
    client.PostAsJsonAsync("http://example.com/" + "relativeAddress",
                new
                {
                    name = "John Doe",
                    age = 33
                });
//Do what you need to do with your response
var app = builder.Build();

// Configure the HTTP request pipeliZ
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
//app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:57013"));
//app.Use((req, res, next) => {
//    res.setHeader("Acces-Control-Allow-Origin", "*");
//    res.setHeader("Acces-Control-Allow-Methods", "GET,POST,PUT,PATCH,DELETE");
//    res.setHeader("Acces-Contorl-Allow-Methods", "Content-Type","Authorizatio");
//    next();
//});
app.UseHttpsRedirection();
//app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
app.Run();
