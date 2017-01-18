using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportUniqueID : IEqualityComparer<ISupportUniqueID>
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

        bool Equal(ISupportUniqueID Other);

        /// <summary>
        /// Pre-calculated hashcode. This value is should be calculated by constructor and also whenever the unique ID <see cref="UniqueID"/> is change by calling <see cref="AssignUniqueID(Guid)"/>
        /// </summary>
        int CachedHashCode { get; }

        /// <summary>
        /// GetHashCode override implementation returns hashcode of UniqueID Guid <see cref="UniqueID"/>
        /// </summary>
        /// <returns>Hashcode</returns>
        int GetHashCode();
    }
}
