using HexagonalArchitecture.DataBase;
using HexagonalArchitecture.Email;
using HexagonalArchitecture.ExternalApis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEmailModule();
builder.Services.AddDataBaseModule();
builder.Services.AddExternalApisModule();

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
