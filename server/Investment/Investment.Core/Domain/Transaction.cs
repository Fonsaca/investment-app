using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{
    public abstract class Transaction
    {
        public decimal Quantity { get; private set; }

        public string Currency { get; private set; }

        public decimal UnitPrice { get; private set; }

        public decimal TotalPrice
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }

        public DateOnly Date { get; private set; }

        public Institution Broker { get; private set; }

        public Investor Owner { get; private set; }

        public Asset Asset { get; private set; }


        protected Transaction(string currency, decimal quantity, decimal unitPrice
            , DateOnly transactionDate, Institution broker, Investor owner, Asset asset)
        {
            Currency = currency;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Date = transactionDate;
            Broker = broker;
            Owner = owner;
            Asset = asset;
        }
    }
}
