using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Investment.Core.Domain
{
    /// <summary>
    /// Represents a category goal of an investment plan
    /// </summary>
    public class WalletAsset : Asset
    {
        public string Currency { get; internal set; }

        public decimal Quantity { get; internal set; }

        public decimal MeanPrice { get; internal set; }

        public decimal CurrentPrice  { get; internal set; }


        private float _targetPercentage = 0;
        public float TargetPercentage
        {
            get
            {
                return _targetPercentage;
            }
            internal set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Percentage", "Value is lower than zero. Acceptable range is [0, 100]");
                if (value > 100)
                    throw new ArgumentOutOfRangeException("Percentage", "Value is greater than 100. Acceptable range is [0, 100]");

                _targetPercentage = value;
            }
        }


        public WalletAsset(Asset asset, string currency) : base(asset.Code, asset.Name, asset.Category, asset.Exchange)
        {
            Currency = currency;
        }
    }
}
