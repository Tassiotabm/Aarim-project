using Arim.Data.Repository.Abstractions;
using System;
using System.Threading.Tasks;

namespace Aarim.Data.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        ICreditCardRepository CreditCard { get; }

        int Complete();
        Task<int> CompleteAsync();
    }
}