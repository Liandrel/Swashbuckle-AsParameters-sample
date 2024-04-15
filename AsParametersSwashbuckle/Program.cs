using AsParametersSwashbuckle.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/test", ([FromQuery] ConditionState conditionStateFromQuery,
                     [AsParameters] RequestModel model) =>
{
    return $"{conditionStateFromQuery}, {model.conditionStateAsParameters}";
});

app.Run();