using InvestBack.ArquiteturaFIAP.Api.Configuration;
using InvestBack.ArquiteturaFIAP.Api.Endpoints;
using InvestBack.ArquiteturaFIAP.Core.Entities;
using InvestBack.ArquiteturaFIAP.Infrastructure.Interfaces;
using InvestBack.ArquiteturaFIAP.Infrastructure.Repositories;
using InvestBack.ArquiteturaFIAP.Service.Interfaces;
using InvestBack.ArquiteturaFIAP.Service.Services;
using MongoDB.Driver;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IWalletService, WalletService>();

builder.Services.AddTransient<IRepository<Entity>, Repository<Entity>>();

builder.Services.AddTransient<IWallerRepository, WalletRepository>();

// Configurando a conexão com o MongoDB
builder.Services.AddSingleton<IMongoClient>(serviceProvider =>
{
    var configuration = serviceProvider.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    return new MongoClient(connectionString);
});
//Configuração conexão mongoDB END

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
