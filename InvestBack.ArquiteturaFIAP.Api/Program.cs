using InvestBack.ArquiteturaFIAP.Api.Configuration;
using InvestBack.ArquiteturaFIAP.Api.Endpoints;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.AddDocumentation();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapperEndpoints();

app.Run();
