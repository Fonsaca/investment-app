using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Exceptions
{
    public class NotSupportedCurrencyException : Exception
    {
        public string Currency { get; private set; }
        public NotSupportedCurrencyException(string currency) : base($"{currency} is not supported")
        {
            Currency = currency;   
        }

    }
}
