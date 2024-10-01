using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{
    public class Institution
    {
        public string Code { get; private set; }

        public string Name { get; private set; }

        public string Segment { get; private set; }

        public string CountryCode { get; private set; }

        public Institution(string code, string name, string segment, string countryCode)
        {
            Code = code;

            Name = name;

            Segment = segment;

            CountryCode = countryCode;
        }
    }
}
