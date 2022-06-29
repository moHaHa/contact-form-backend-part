global using Microsoft.EntityFrameworkCore;
global using ContactAPI.data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineConnection"))
 );
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
var app = builder.Build();
app.UseCors(c=> c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.MapGet("/", ()=> "hi");
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
