using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChillX.Framework.Common.Enumeration;
using ChillX.Framework.Common.CapabilityInterface;

namespace ChillX.Framework.Common.Routing
{
    /// <summary>
    /// Base class for all routable messages
    /// </summary>
    [Serializable]
    public class RoutableMessageBase : ISupportRouting
    {
        public RoutableMessageBase()
        {
            m_RoutingSourceEndPoint = new RoutingEndPoint();
            m_RoutingContentType = new ContentTypeEndPoint();
            m_RoutingMicroService = new MicroServiceEndPoint();
        }
        public RoutableMessageBase(Guid _RoutingSourceEndPointID)
        {
            m_RoutingSourceEndPoint = new RoutingEndPoint(_RoutingSourceEndPointID);
            m_RoutingContentType = new ContentTypeEndPoint();
            m_RoutingMicroService = new MicroServiceEndPoint();
        }
        public RoutableMessageBase(Guid _RoutingSourceEndPointID, Enum_ContentType _ContentType)
        {
            m_RoutingSourceEndPoint = new RoutingEndPoint(_RoutingSourceEndPointID);
            m_RoutingContentType = new ContentTypeEndPoint();
            m_RoutingMicroService = new MicroServiceEndPoint();
        }
        public RoutableMessageBase(Guid _RoutingSourceEndPointID, Enum_ContentType _ContentType, string _MicroServiceName, string _FunctionGroupName, string _FunctionName)
        {
            m_RoutingSourceEndPoint = new RoutingEndPoint(_RoutingSourceEndPointID);
            m_RoutingContentType = new ContentTypeEndPoint(_ContentType);
            m_RoutingMicroService = new MicroServiceEndPoint(_MicroServiceName, _FunctionGroupName, _FunctionName);
        }
        private DateTime m_CreationDate = DateTime.Now;
        protected RoutingEndPoint m_RoutingSourceEndPoint;
        protected ContentTypeEndPoint m_RoutingContentType;
        protected MicroServiceEndPoint m_RoutingMicroService;

        public DateTime CreationDate
        {
            get
            {
                return m_CreationDate;
            }

            set
            {
                m_CreationDate = value;
            }
        }

        public ISupportUniqueID RoutingSourceEndPoint
        {
            get
            {
                return m_RoutingSourceEndPoint;
            }
        }

        public ISupportRoutingContentType RoutingContentType
        {
            get
            {
                return m_RoutingContentType;
            }
        }
        public ISupportRoutingMicroService RoutingMicroService
        {
            get
            {
                return m_RoutingMicroService;
            }
        }

    }
}
