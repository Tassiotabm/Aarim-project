using Aarim.Data;
using Aarim.Models;
using Arim.Data.Repository.Abstractions;

namespace Arim.Data.Repository
{
    public class CreditCardRepository : Repository<DomainDbContext, CreditCard>, ICreditCardRepository
    {
        public CreditCardRepository(DomainDbContext context) : base(context)
        {

        }
    }
}
