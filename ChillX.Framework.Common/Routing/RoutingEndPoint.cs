using ChillX.Framework.Common.ApplicationBlocks;
using ChillX.Framework.Common.CapabilityInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.Routing
{
    /// <summary>
    /// Unique end point of a node in the routing grid.
    /// Note: This could be a client node or it could be a server node
    /// </summary>
    [Serializable]
    public class RoutingEndPoint : AppBlockSupportUniqueID, IEqualityComparer<RoutingEndPoint>
    {
        /// <summary>
        /// Initializes this instance with a new generated end point ID
        /// </summary>
        public RoutingEndPoint()
            : base()
        {
        }
        /// <summary>
        /// Initializes this instance with the specified end point ID
        /// </summary>
        /// <param name="_EndPointUniqueID">Routing destination endpoint unique ID</param>
        public RoutingEndPoint(Guid _EndPointUniqueID)
            : base(_EndPointUniqueID)
        {
        }
 
        /// <summary>
        /// Equality comparer - Syntax convenience method - Base class already implements this.
        /// </summary>
        /// <param name="Other">Other instance to compare against</param>
        /// <returns>Equality</returns>
        public bool Equal(RoutingEndPoint Other)
        {
            return UniqueID.Equals(Other.UniqueID);
        }

        /// <summary>
        /// Equality comparer - Syntax convenience method - Base class already implements this.
        /// </summary>
        /// <param name="x">First instance to compare</param>
        /// <param name="y">Second instance to compare</param>
        /// <returns>Equality</returns>
        public bool Equals(RoutingEndPoint x, RoutingEndPoint y)
        {
            return x.UniqueID.Equals(y.UniqueID);
        }

        /// <summary>
        /// Get Hashcode - Syntax convenience method - Base class already implements this.
        /// Note: for perfomance reasons this returns a precalculated value <see cref="CachedHashCode"/>
        /// </summary>
        /// <param name="obj">Other instance to compare against</param>
        /// <returns>Hashcode</returns>
        public int GetHashCode(RoutingEndPoint obj)
        {
            return obj.CachedHashCode;
        }
    }
}
