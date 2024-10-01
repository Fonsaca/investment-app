using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{
    public class Sell : Transaction
    {

        public Sell(string currency, decimal quantity, decimal unitPrice
            , DateOnly transactionDate, Institution broker, Investor owner
            , WalletAsset asset) 
            : base(currency, quantity, unitPrice, transactionDate, broker, owner, asset)
        {

        }
    }
}
