using Aarim.Data.Abstractions;
using Aarim_Data.Repository;
using Aarim_Data.Repository.Abstractions;
using Arim.Data.Repository;
using Arim.Data.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aarim.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DomainDbContext _context;

        public UnitOfWork(DomainDbContext context)
        {
            _context = context;
            CreditCard = new CreditCardRepository(_context);
            Transaction = new TransactionRepository(_context);
        }

        public ICreditCardRepository CreditCard { get; private set; }
        public ITransactionRepository Transaction { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
