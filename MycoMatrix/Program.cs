using MycoMatrix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(); //for PATCH
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<MycoMatrixContext>(
    dbContextOptions => dbContextOptions
    .UseMySql(
        builder.Configuration["ConnectionStrings:DefaultConnection"],
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
    )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiVersioning(opt =>
                                    {
                                        opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                                        opt.AssumeDefaultVersionWhenUnspecified = true;
                                        opt.ReportApiVersions = true;
                                        opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                                                        new HeaderApiVersionReader("x-api-version"),
                                                                                        new MediaTypeApiVersionReader("x-api-version"));
                                    });
builder.Services.AddSwaggerGen(c => //add versioning
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OG", Version = "v1 "});
    c.ResolveConflictingActions(c => c.Last()); //bc 2 gets, swagger has issue (api is fine), uses default version if conflict.  if 2.0 is default, take last. if 1.0 default, take first.
});                               

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
