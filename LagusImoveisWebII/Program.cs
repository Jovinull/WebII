using AutoMapper;
using LagusImoveisWebII.Context;
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(Options => {
    Options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
 });
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<IPropriedadeRepository, PropriedadeRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();

builder.Services.AddDbContext<LagusImoveisWebIIContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), assembly  => assembly.MigrationsAssembly(typeof(LagusImoveisWebIIContext).Assembly.FullName));
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
