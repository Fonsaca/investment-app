using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{
    public class Buy : Transaction
    {

        public Buy(string currency, decimal quantity, decimal unitPrice
            , DateOnly transactionDate, Institution broker, Investor owner
            , Asset asset) 
            : base(currency,quantity,unitPrice,transactionDate,broker, owner, asset)
        {
            
        }
    }
}
