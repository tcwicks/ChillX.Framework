using ChillX.Framework.Common.Enumeration;

namespace ChillX.Framework.Common.CapabilityInterface
{
    /// <summary>
    /// Interface: Mime content type end point for message routing purposes. See base implementation <see cref="ContentTypeEndPoint"/>
    /// </summary>
    public interface ISupportRoutingContentType
    {
        /// <summary>
        /// Mime content type
        /// </summary>
        Enum_ContentType ContentType { get; }

        /// <summary>
        /// Reassign a different mime content type to this instance
        /// </summary>
        /// <param name="_ContentType"></param>
        void AssignContentType(Enum_ContentType _ContentType);
    }
}