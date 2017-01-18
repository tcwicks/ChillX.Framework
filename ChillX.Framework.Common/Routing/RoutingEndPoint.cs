using ChillX.Framework.Common.CapabilityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.Routing
{
    public class RoutingEndPoint : ISupportUniqueID
    {
        /// <summary>
        /// Initializes this instance with a new generated end point ID
        /// </summary>
        public RoutingEndPoint()
        {
            AssignUniqueID(Guid.NewGuid());
        }
        /// <summary>
        /// Initializes this instance with the specified end point ID
        /// </summary>
        /// <param name="_EndPointUniqueID">Routing destination endpoint unique ID</param>
        public RoutingEndPoint(Guid _EndPointUniqueID)
        {
            AssignUniqueID(_EndPointUniqueID);
        }
        private Guid m_UniqueID;

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
        /// Reassign a different endpoint ID to this instance
        /// </summary>
        /// <param name="_EndPointUniqueID">New end point ID</param>
        public void AssignUniqueID(Guid _EndPointUniqueID)
        {
            m_UniqueID = _EndPointUniqueID;
        }
    }
}
