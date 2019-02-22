using Aarim.Data.Abstractions;
using Aarim.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aarim.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _uow;

        public TransactionService(IUnitOfWork uow)
        {
            _uow = uow;
        }
    }
}
