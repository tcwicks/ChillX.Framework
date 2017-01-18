using ChillX.Framework.Common.CapabilityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.ApplicationBlocks
{
    public class AppBlockSupportUniqueID : ISupportUniqueID
    {
        /// <summary>
        /// Initializes this instance with the end point ID for this node see <see cref="GlobalProperty.CurrentNodeID"/>
        /// </summary>
        public AppBlockSupportUniqueID()
        {
            AssignUniqueID(GlobalProperty.CurrentNodeID);
        }

        /// <summary>
        /// Initializes this instance with the specified end point ID
        /// </summary>
        /// <param name="_EndPointUniqueID">Routing destination endpoint unique ID</param>
        public AppBlockSupportUniqueID(Guid _EndPointUniqueID)
        {
            AssignUniqueID(_EndPointUniqueID);
        }

        private Guid m_UniqueID;
        private int m_CachedHashCode;

        /// <summary>
        /// Unique routing destination endpoint ID;
        /// </summary>
        public Guid UniqueID
        {
            get
            {
                return m_UniqueID;
            }
        }

        /// <summary>
        /// Pre-calculated hashcode. this value is calculated by constructor and also whenever the unique ID <see cref="UniqueID"/> is change by calling <see cref="AssignUniqueID(Guid)"/>
        /// </summary>
        public int CachedHashCode
        {
            get
            {
                return m_CachedHashCode;
            }
        }

        /// <summary>
        /// Reassign a different endpoint ID to this instance
        /// </summary>
        /// <param name="_EndPointUniqueID">New end point ID</param>
        public void AssignUniqueID(Guid _EndPointUniqueID)
        {
            m_UniqueID = _EndPointUniqueID;
            m_CachedHashCode = m_UniqueID.GetHashCode();
        }

        /// <summary>
        /// Equality comparer
        /// </summary>
        /// <param name="Other">Other instance to compare against</param>
        /// <returns>Equality</returns>
        public bool Equal(ISupportUniqueID Other)
        {
            return UniqueID.Equals(Other.UniqueID);
        }

        /// <summary>
        /// Equality comparer
        /// </summary>
        /// <param name="x">First instance to compare</param>
        /// <param name="y">Second instance to compare</param>
        /// <returns>Equality</returns>
        public bool Equals(ISupportUniqueID x, ISupportUniqueID y)
        {
            return x.UniqueID.Equals(y.UniqueID);
        }

        /// <summary>
        /// Equality comparer
        /// </summary>
        /// <param name="obj">Other instance to compare against</param>
        /// <returns>Equality</returns>
        public override bool Equals(object obj)
        {
            AppBlockSupportUniqueID Other;
            Other = obj as AppBlockSupportUniqueID;
            if (Other == null)
            {
                return base.Equals(obj);
            }
            return UniqueID.Equals(Other.UniqueID);
        }

        /// <summary>
        /// GetHashCode implementation returns hashcode of UniqueID Guid <see cref="UniqueID"/>
        /// Note: for perfomance reasons this returns a precalculated value <see cref="CachedHashCode"/>
        /// </summary>
        /// <param name="obj">Instance to return hashcode for</param>
        /// <returns>Hashcode</returns>
        public int GetHashCode(ISupportUniqueID obj)
        {
            return obj.CachedHashCode;
        }

        /// <summary>
        /// GetHashCode override implementation returns hashcode of UniqueID Guid <see cref="UniqueID"/>
        /// Note: for perfomance reasons this returns a precalculated value <see cref="CachedHashCode"/>
        /// </summary>
        /// <returns>Hashcode</returns>
        public override int GetHashCode()
        {
            return CachedHashCode;
        }

    }
}
