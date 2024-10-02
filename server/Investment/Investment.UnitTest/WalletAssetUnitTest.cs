using Investment.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.UnitTest
{
    public class WalletAssetUnitTest
    {

        [Fact]
        public void OnCreateAndUpdate_InvalidCurrency_ThrowsException()
        {

            Assert.Throws<NotSupportedCurrencyException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_TargetPercentageIsGreaterThan100_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_NegativeQuantity_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_NegativeCurrentPrice_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_NegativeMeanPrice_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_NegativeTargetPercentage_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreate_AssertSuccess()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnUpdate_AssertSuccess()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }
    }
}
