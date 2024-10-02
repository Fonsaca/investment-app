using Investment.Core.Domain;
using Investment.Core.Exceptions;

namespace Investment.UnitTest
{
    public class InvestmentPlanUnitTest
    {
        [Fact]
        public void OnCreateAndUpdate_NullCurrency_ThrowsException()
        {

            Assert.Throws<ArgumentNullException>(() => { 
            
                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_InvalidCurrency_ThrowsException()
        {

            Assert.Throws<NotSupportedCurrencyException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_MissingWalletAsset_ThrowsException()
        {

            Assert.Throws<ArgumentNullException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_TotalPercentageIsGreaterThan100_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreateAndUpdate_MoneyGoalIsLowerThanZero_ThrowsException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => {

                //TODO

            });

        }

        [Fact]
        public void OnCreate_AssertSuccess()
        {

            Assert.True(false);

        }

        [Fact]
        public void OnUpdate_AssertSuccess()
        {

            Assert.True(false);

        }

    }
}