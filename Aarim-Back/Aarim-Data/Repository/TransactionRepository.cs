using Aarim.Data;
using Aarim_Data.Repository.Abstractions;
using Arim.Data.Repository;
using System.Transactions;

namespace Aarim_Data.Repository
{
    public class TransactionRepository : Repository<DomainDbContext, Transaction>, ITransactionRepository
    {
        public TransactionRepository(DomainDbContext context) : base(context)
        {

        }
    }
}
