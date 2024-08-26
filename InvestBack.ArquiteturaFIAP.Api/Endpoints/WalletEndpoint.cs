using InvestBack.ArquiteturaFIAP.Api.Service.Requests;
using InvestBack.ArquiteturaFIAP.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InvestBack.ArquiteturaFIAP.Api.Endpoints
{
    public static class WalletEndpoint
    {
        public static void MapperEndpoints(this WebApplication app)
        {
            var walletGroup = app.MapGroup("/api/wallet")
                                 .WithTags("Wallet");

            // Endpoint para criar um novo wallet
            walletGroup.MapPost("/create", (WalletRequest wallet, IWalletService walletService) => 
            {
                return Create(wallet, walletService);
            })
            .WithName("WalletCreate")
            .WithSummary("Create a new transaction record.")
            .WithDescription("Creates and saves a new transaction in the system")
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status500InternalServerError);

            // Endpoint para atualizar um wallet
            walletGroup.MapPut("/{id}", (string id, WalletRequest wallet, IWalletService walletService) =>
            {
                return Update(id, wallet, walletService);
            })
            .WithName("WalletUpdate")
            .WithSummary("Update an existing transaction record.")
            .WithDescription("Updates an existing transaction in the system")
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status500InternalServerError);

            //// Endpoint para obter um wallet por ID
            //walletGroup.MapGet("/{id}", (string id, IWalletService walletService) =>
            //{
            //    return GetById(id, walletService);
            //})
            //.WithName("WalletGetById")
            //.WithSummary("Get a transaction record by ID.")
            //.WithDescription("Retrieves a transaction from the system by its ID")
            //.Produces<WalletResponse>(StatusCodes.Status200OK)
            //.Produces(StatusCodes.Status404NotFound)
            //.Produces(StatusCodes.Status500InternalServerError);

            //// Endpoint para remover um wallet
            //walletGroup.MapDelete("/{id}", (string id, IWalletService walletService) =>
            //{
            //    return Remove(id, walletService);
            //})
            //.WithName("WalletRemove")
            //.WithSummary("Remove a transaction record.")
            //.WithDescription("Removes a transaction from the system by its ID")
            //.Produces(StatusCodes.Status204NoContent)
            //.Produces(StatusCodes.Status404NotFound)
            //.Produces(StatusCodes.Status500InternalServerError);
        }

        private static async Task<IResult> Create(WalletRequest wallet, IWalletService walletService)
        {
            await walletService.CreateWalletAsync(wallet);
            return Results.Ok("Wallet created successfully.");
        }

        private static async Task<IResult> Update(string id, WalletRequest wallet, IWalletService walletService)
        {
            var result = await walletService.UpdateWalletAsync(id, wallet);
            return result ? Results.Ok("Wallet updated successfully.") : Results.NotFound("Wallet not found.");
        }

        //private static async Task<IResult> GetById(string id, IWalletService walletService)
        //{
        //    var wallet = await walletService.GetWalletByIdAsync(id);
        //    return wallet != null ? Results.Ok(wallet) : Results.NotFound("Wallet not found.");
        //}

        //private static async Task<IResult> Remove(string id, IWalletService walletService)
        //{
        //    var result = await walletService.RemoveWalletAsync(id);
        //    return result ? Results.NoContent() : Results.NotFound("Wallet not found.");
        //}
    }
}
