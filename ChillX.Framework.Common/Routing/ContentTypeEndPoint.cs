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
    /// Mime content type end point for message routing purposes
    /// </summary>
    public class ContentTypeEndPoint : ISupportRoutingContentType
    {
        /// <summary>
        /// Intializes this ContentTypeEndPoint instance with content type as generic application_octet_stream mime type
        /// </summary>
        public ContentTypeEndPoint()
        {
            AssignContentType(Enum_ContentType.application_octet_stream);
        }
        /// <summary>
        /// Intializes this ContentTypeEndPoint instance with the specified content type (mime type)
        /// </summary>
        /// <param name="_ContentType">Content type for this instance</param>
        public ContentTypeEndPoint(Enum_ContentType _ContentType)
        {
            AssignContentType(_ContentType);
        }
        private Enum_ContentType m_ContentType;

        /// <summary>
        /// Mime content type
        /// </summary>
        public Enum_ContentType ContentType
        {
            get
            {
                return m_ContentType;
            }
        }

        /// <summary>
        /// Reassign a different mime content type to this instance
        /// </summary>
        /// <param name="_ContentType"></param>
        public void AssignContentType(Enum_ContentType _ContentType)
        {
            m_ContentType = _ContentType;
        }
    }
}
