using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Domain
{

    public sealed class Investor
    {
        /// <summary>
        /// Unique identifier created by the user service
        /// </summary>
        private Guid _id;
        public Guid Id
        {
            get
            {
                return _id;
            }
            set {
                if (_id == default)
                    throw new Exception("Imutable property"); //TODO: Create domain exception
                _id = value; 
            }
        }

        /// <summary>
        /// The investor display name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public Investor() {}



    }
}
