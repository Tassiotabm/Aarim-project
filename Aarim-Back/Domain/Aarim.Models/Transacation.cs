using System;
using System.Collections.Generic;
using System.Text;

namespace Aarim.Models
{
    public class Transacation
    {
        public Guid TransacationId { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public CreditCard Card { get; set; }
        public string Number { get; set; }
    }
}

/*
    Amount | Valor da transação
    Type | Tipo da transação
    Card | Propriedades do cartão
    Number | Número de parcelas, **se for uma transação de crédito parcelado**
*/
