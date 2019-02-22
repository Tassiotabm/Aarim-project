using Aarim.Data.Abstractions;
using Aarim.Services.Abstractions;
using System;

namespace Aarim.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly IUnitOfWork _uow;

        public CreditCardService(IUnitOfWork uow)
        {
            _uow = uow;
        }

    }
}
