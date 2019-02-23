using Aarim.Models;
using System.Threading.Tasks;

namespace Aarim.Services.Abstractions
{
    public interface ICreditCardService
    {
        Task CreateCreditCard(CreditCard newCreditCard);
    }
}