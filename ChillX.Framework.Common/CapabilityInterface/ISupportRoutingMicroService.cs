namespace ChillX.Framework.Common.CapabilityInterface
{
    /// <summary>
    /// Interface: MicroService end point for routing purposes see <see cref="MicroServiceEndPoint"/>
    /// </summary>
    public interface ISupportRoutingMicroService
    {
        /// <summary>
        /// Microservice name
        /// </summary>
        string MicroServiceName { get; }

        /// <summary>
        /// Function group name within specified micro service <see cref="MicroServiceName"/>
        /// </summary>
        string FunctionGroupName { get; }

        /// <summary>
        /// Function name within specified micro service function group <see cref="MicroServiceName"/> and <see cref="FunctionGroupName"/>
        /// </summary>
        string FunctionName { get; }

        /// <summary>
        /// Routing Key which is in the format string.concat(<see cref="MicroServiceName"/>, @":", <see cref="FunctionGroupName"/>, @":", <see cref="FunctionName"/>)
        /// Note: this is a lower case trimmed invariant culture string
        /// </summary>
        string RoutingKey { get; }

        /// <summary>
        /// Pre-calculated hashcode. This value should be calculated by constructor
        /// and also whenever the routing key is changed <see cref="RoutingKey"/> is changed by changing either <see cref="MicroServiceName"/> or <see cref="FunctionGroupName"/> or <see cref="FunctionName"/>
        /// </summary>
        int CachedHashCode { get; }

        /// <summary>
        /// Assign new value for micro service name <see cref="MicroServiceName"/>
        /// </summary>
        /// <param name="_MicroServiceName"></param>
        void AssignMicroServiceName(string _MicroServiceName);

        /// <summary>
        /// Assign new value for micro service function group name <see cref="FunctionGroupName"/>
        /// </summary>
        /// <param name="_FunctionGroupName"></param>
        void AssignFunctionGroupName(string _FunctionGroupName);

        /// <summary>
        /// Assign new value for function name within specified micro service function group <see cref="MicroServiceName"/> and <see cref="FunctionGroupName"/>
        /// </summary>
        /// <param name="_FunctionName"></param>
        void AssignFunctionName(string _FunctionName);
    }
}