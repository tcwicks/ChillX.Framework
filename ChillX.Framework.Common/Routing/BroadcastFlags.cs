using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChillX.Framework.Common.CapabilityInterface;

namespace ChillX.Framework.Common.Routing
{
    /// <summary>
    /// Message broadcast flags wrapper base class for message routing purposes
    /// </summary>
    [Serializable]
    public class BroadcastFlags : ISupportRoutingBroadcast
    {
        private bool m_IsBroadcastMessage;
        private bool m_BroadCastIncludeServerSide;
        private bool m_BroadcastIncludeClientSide;

        /// <summary>
        /// Flag indicates if this is a broadcast message
        /// </summary>
        public bool IsBroadcastMessage
        {
            get
            {
                return m_IsBroadcastMessage;
            }

            set
            {
                m_IsBroadcastMessage = value;
            }
        }

        /// <summary>
        /// If this is a broadcast message see <see cref="IsBroadcastMessage"/>
        /// Flag indicates if this message shoud be broadcast to all server nodes
        /// </summary>
        public bool BroadCastIncludeServerSide
        {
            get
            {
                return m_BroadCastIncludeServerSide;
            }

            set
            {
                m_BroadCastIncludeServerSide = value;
            }
        }

        /// <summary>
        /// If this is a broadcast message see <see cref="IsBroadcastMessage"/>
        /// Flag indicates if this message shoud be broadcast to all client nodes
        /// </summary>
        public bool BroadcastIncludeClientSide
        {
            get
            {
                return m_BroadcastIncludeClientSide;
            }

            set
            {
                m_BroadcastIncludeClientSide = value;
            }
        }

        /// <summary>
        /// Convenience method - sets flags for a server side broadcast only
        /// </summary>
        public void EnableBroadcastServerSide()
        {
            m_IsBroadcastMessage = true;
            m_BroadCastIncludeServerSide = true;
            m_BroadcastIncludeClientSide = false;
        }

        /// <summary>
        /// Convenience method - sets flags for a client side broadcast only
        /// </summary>
        public void EnableBroadcastClientSide()
        {
            m_IsBroadcastMessage = true;
            m_BroadCastIncludeServerSide = false;
            m_BroadcastIncludeClientSide = true;
        }

        /// <summary>
        /// Convenience method - sets flags for both server side and client side broadcast
        /// </summary>
        public void EnableBroadcastAll()
        {
            m_IsBroadcastMessage = true;
            m_BroadCastIncludeServerSide = true;
            m_BroadcastIncludeClientSide = true;
        }

        /// <summary>
        /// Convenience method - unsets all broadcast flags disabling all broadcast.
        /// </summary>
        public void DisableBroadcastAll()
        {
            m_IsBroadcastMessage = false;
            m_BroadCastIncludeServerSide = false;
            m_BroadcastIncludeClientSide = false;
        }
    }
}
