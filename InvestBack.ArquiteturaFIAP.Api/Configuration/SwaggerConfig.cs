namespace InvestBack.ArquiteturaFIAP.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddDocumentation(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(x =>
            {
                x.CustomSchemaIds(n => n.FullName);
            });
        }
    }
}
