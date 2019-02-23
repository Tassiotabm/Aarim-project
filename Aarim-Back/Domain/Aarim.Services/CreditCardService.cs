using Aarim.Data.Abstractions;
using Aarim.Models;
using Aarim.Services.Abstractions;
using Arim.Data.Repository.Abstractions;
using System;
using System.Threading.Tasks;

namespace Aarim.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly IUnitOfWork _uow;
        private readonly ICreditCardRepository _creditCardrepository;

        public CreditCardService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task CreateCreditCard(CreditCard newCreditCard)
        {
            await _uow.CreditCard.Add(newCreditCard);
        }
    }
}
