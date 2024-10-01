using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{
    public class Asset
    {
        /// <summary>
        /// Asset unique code
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Asset Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Example: fixed income yield.
        /// 
        /// For equities this property shall be null.
        /// </summary>
        public string? Profitability { get; set; }

        /// <summary>
        /// Example: Fixed Income, Equities, Real State, Derivatives, Crypto..
        /// </summary>
        public string Category { get; private set; }

        /// <summary>
        /// Treasure Bonds, Munis, CD...
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Date when the investment expires and the cash is refunded
        /// </summary>
        public DateOnly? MaturityDate { get; set; }


        public Asset(string code, string name, string category, string type)
        {

            if(string.IsNullOrEmpty(code))
                throw new ArgumentNullException("code");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            if (string.IsNullOrEmpty(category))
                throw new ArgumentNullException("category");

            if (string.IsNullOrEmpty(type))
                throw new ArgumentNullException("type");

            Code = code;
            Name = name;
            Category = category;
            Type = type;
        }
    }
}
