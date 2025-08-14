using Valhalla.Api.Config.MediatR;
using Valhalla.Api.Config.Swagger;
using Valhalla.Api.Config.Transient;
using Valhalla.Api.Config.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRepositories();
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.AddMediatRHandlers();
builder.Services.AddSwaggerConfig(); 

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Valhalla API v1");
    c.RoutePrefix = string.Empty; 
});


app.UseRouting();
app.MapControllers();
app.Run();
