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

        public double MoneyGoal { get; internal set; }

        public string Details { get; internal set; } = string.Empty;


        private List<CategoryGoal> _categoryGoals = new List<CategoryGoal>();
        public IReadOnlyList<CategoryGoal> CategoryGoals
        {
            get { return _categoryGoals.AsReadOnly(); }
        }


        private List<AssetGoal> _assetGoals = new List<AssetGoal>();
        public IReadOnlyList<AssetGoal> AssetGoals
        {
            get { return _assetGoals.AsReadOnly(); }
        }


        public InvestmentPlan(int id)
        {
            Id = id;
        }



        internal void AddCategoryGoal(string category, short percentage) {
            if (goal != null)
                _categoryGoals.Add(goal);
        }

        internal void AddAssetGoal(Asset asset, short percentage)
        {
            if (asset != null)
            {
                var goal = new AssetGoal()
                {
                    Percentage = percentage
                }
            }
        }
    }
}
