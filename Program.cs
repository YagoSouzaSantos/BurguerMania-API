using BurguerMania_API.Data;
using BurguerMania_API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração do DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 25))));

// Registra os serviços e repositórios
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<CategoryService>();

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<CategoryRepository>();

// Configuração do AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// Adiciona o suporte a Controllers
builder.Services.AddControllers();  // Esta linha é importante

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia as controllers para que as rotas sejam reconhecidas
app.MapControllers();  // Esta linha é essencial para mapear as controllers

app.Run();
