using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{
    public class InvestmentPlan
    {
        public int Id { get; private set; }

        public string Title { get; internal set; } = string.Empty;

        public string Currency { get; internal set; } = string.Empty; //TODO validate using some resource file

        public decimal MoneyGoal { get; internal set; }

        public string Details { get; internal set; } = string.Empty;


        private List<WalletAsset> _assetGoals = new List<WalletAsset>();
        public IReadOnlyList<WalletAsset> AssetGoals
        {
            get { return _assetGoals.AsReadOnly(); }
        }


        public InvestmentPlan(int id)
        {
            Id = id;
        }



    }
}
