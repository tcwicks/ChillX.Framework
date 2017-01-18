using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportUniqueID
    {
        /// <summary>
        /// Unique ID
        /// </summary>
        Guid UniqueID { get; }

        /// <summary>
        /// Reassign unique ID of this instance
        /// </summary>
        /// <param name="_UniqueID">new UniqueID</param>
        void AssignUniqueID(Guid _UniqueID);
    }
}
