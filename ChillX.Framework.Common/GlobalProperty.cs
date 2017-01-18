using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common
{
    public static class GlobalProperty
    {
        private static Guid m_CurrentNodeID = Guid.NewGuid();

        /// <summary>
        /// The unique ID of this node. Used for message routing
        /// Note: This value is initialized on process startup and will not change for the process lifetime
        /// </summary>
        public static Guid CurrentNodeID
        {
            get
            {
                return m_CurrentNodeID;
            }
        }
    }
}
