namespace InvestBack.ArquiteturaFIAP.Api.Endpoints
{
    public static class TransactionsEndpoint
    {
        public static void MapperEndpoints(this WebApplication app)
        {

            var aporteGroup = app.MapGroup("/api/transaction")
                                 .WithTags("Transactions");

            aporteGroup.MapPost("/create", (Delegate)Create)
                       .WithName("TransactionCreate")
                       .WithSummary("Create a new transaction record.")
                       .WithDescription("Creates and saves a new transaction in the system")
                       .Produces(StatusCodes.Status200OK)
                       .Produces(StatusCodes.Status400BadRequest)
                       .Produces(StatusCodes.Status500InternalServerError);
        }

        private static async Task Create()
        {
            throw new NotImplementedException();
        }
    }
}