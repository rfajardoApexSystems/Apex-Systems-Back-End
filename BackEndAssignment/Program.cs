using BackEndAssignment.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


ServiceExtensions.AddSwaggerExtension(builder.Services);
ServiceExtensions.AddBaseServiceExtension(builder.Services);
ServiceExtensions.AddApiVersioningExtension(builder.Services);
ServiceExtensions.AddEntityFramework(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    AppExtensions.UseSwaggerExtension(app);
}

app.MapControllers();

app.Run();
