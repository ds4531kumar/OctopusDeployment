var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Enable API controllers
builder.Services.AddEndpointsApiExplorer();

// Add services to the container.
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));


var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors("AllowAll"); // Enable CORS if configured

app.UseAuthorization();

app.MapControllers(); // Map API Controllers

app.Run();