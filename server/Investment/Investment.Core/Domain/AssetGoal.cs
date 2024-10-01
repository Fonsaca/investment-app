using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{
    /// <summary>
    /// Represents a category goal of an investment plan
    /// </summary>
    public class AssetGoal
    {

        public Asset Asset { get; private set; }

        private short _percentage = 0;
        public short Percentage
        {
            get
            {
                return _percentage;
            }
            internal set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Percentage", "Value is lower than zero. Acceptable range is [0, 100]");
                if (value > 100)
                    throw new ArgumentOutOfRangeException("Percentage", "Value is greater than 100. Acceptable range is [0, 100]");

                _percentage = value;
            }
        }


        public AssetGoal(Asset asset)
        {
            if (asset == null) 
                throw new ArgumentNullException("Asset");

            Asset = asset;
        }
    }
}
