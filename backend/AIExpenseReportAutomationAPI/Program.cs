var builder = WebApplication.CreateBuilder(args);

//add services
builder.Services.AddControllers();

var app = builder.Build();

//map endpoints
app.MapControllers();

app.Run();