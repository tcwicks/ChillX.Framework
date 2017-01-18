using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.Routing
{
    public class MessageRouter
    {
        public MessageRouter(RoutingEndPoint _CurrentNodeEndPointID)
        {
            m_CurrentNodeEndPointID = _CurrentNodeEndPointID;
        }
        private RoutingEndPoint m_CurrentNodeEndPointID;

        public RoutingEndPoint CurrentNodeEndPointID
        {
            get
            {
                return m_CurrentNodeEndPointID;
            }
        }
    }
}
