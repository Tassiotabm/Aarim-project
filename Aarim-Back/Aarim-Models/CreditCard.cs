using Aarim.Models.Enum;
using System;

namespace Aarim.Models
{
    public class CreditCard
    {
        public Guid CreditCardId { get; set; }
        public string CardholderName { get; set; }
        public string Number { get; set; }
        public DateTime ExpirationDate { get; set; }
        public BrandType CardBrand { get; set; }
        public string Password { get; set; }  //temporary
        public CrediCardType Type { get; set; }
        public bool HasPassword { get; set; }
    }
}

/*
    CardholderName | Nome do portador do cartão
    Number | Os números que são impressos no cartão, podendo variar entre 12 à 19 dígitos
    ExpirationDate | Data de expiração do cartão
    CardBrand | Bandeira do cartão
    Password | Senha do cartão
    Type | Chip ou tarja magnética
    HasPassword | Se o cartão possui senha. Apenas cartões de tarja magnética podem ter essa propriedade como `True`
*/
