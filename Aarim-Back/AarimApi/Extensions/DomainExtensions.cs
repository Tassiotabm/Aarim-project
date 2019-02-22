using Aarim.Data;
using Aarim_Data.Repository;
using Aarim_Data.Repository.Abstractions;
using Arim.Data.Repository;
using Arim.Data.Repository.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Aarim.Back.Extensions
{
    public static class DomainExtensions
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<UnitOfWork, UnitOfWork>();
            services.AddScoped<ICreditCardRepository, CreditCardRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

        }
    }
}
