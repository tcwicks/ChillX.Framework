namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportRoutingBroadcast
    {
        /// <summary>
        /// Flag indicates if this is a broadcast message
        /// </summary>
        bool IsBroadcastMessage { get; set; }
        /// <summary>
        /// If this is a broadcast message see <see cref="IsBroadcastMessage"/>
        /// Flag indicates if this message shoud be broadcast to all server nodes
        /// </summary>
        bool BroadCastIncludeServerSide { get; set; }
        /// <summary>
        /// If this is a broadcast message see <see cref="IsBroadcastMessage"/>
        /// Flag indicates if this message shoud be broadcast to all client nodes
        /// </summary>
        bool BroadcastIncludeClientSide { get; set; }

        /// <summary>
        /// Convenience method - sets flags for a server side broadcast only
        /// </summary>
        void EnableBroadcastClientSide();
        /// <summary>
        /// Convenience method - sets flags for a client side broadcast only
        /// </summary>
        void EnableBroadcastServerSide();
        /// <summary>
        /// Convenience method - sets flags for both server side and client side broadcast
        /// </summary>
        void EnableBroadcastAll();
        /// <summary>
        /// Convenience method - unsets all broadcast flags disabling all broadcast.
        /// </summary>
        void DisableBroadcastAll();
    }
}