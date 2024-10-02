using Investment.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.UnitTest
{
    public class TransactionUnitTest
    {
        [Fact]
        public void OnBuy_InvalidCurrency_ThrowsException()
        {

            Assert.Throws<NotSupportedCurrencyException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnBuyAndSell_NegativeQuantity_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnBuyAndSell_NegativeUnitPrice_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }


        [Fact]
        public void OnSell_QuantityIsGreaterThanTheAmountAvailableInTheWallet_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnBuy_DateIsLowerThanBornDate_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnSell_DateIsGreaterThanMaturityDate_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }


        [Fact]
        public void OnBuy_AssertSuccess()
        {

            Assert.True(false);

        }

        [Fact]
        public void OnSell_AssertSuccess()
        {

            Assert.True(false);

        }

    }
}
