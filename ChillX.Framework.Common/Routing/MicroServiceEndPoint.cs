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
    /// MicroService end point for routing purposes
    /// </summary>
    public class MicroServiceEndPoint : ISupportRoutingMicroService
    {
        /// <summary>
        /// Initializes this MicroServiceEndPoint with empty string values for all parameters <see cref="MicroServiceName"/>, <see cref="FunctionGroupName"/>, <see cref="FunctionName"/>;
        /// </summary>
        public MicroServiceEndPoint()
        {
            m_MicroServiceName = string.Empty;
            m_FunctionGroupName = string.Empty;
            m_FunctionName = string.Empty;
            CalculateHashCodeAndRoutingKey();
        }
        /// <summary>
        /// Initializes this MicroServiceEndPoint with specified values for all parameters <see cref="MicroServiceName"/>, <see cref="FunctionGroupName"/>, <see cref="FunctionName"/>;
        /// Note: character : is not allowed in any of the parameters and will be replaced by .
        /// Note: value of all parameters will be trimmed and cast to a lower case invariant culture string
        /// </summary>
        /// <param name="_MicroServiceName">Target microservice name</param>
        /// <param name="_FunctionGroupName">Target microservice function group name</param>
        /// <param name="_FunctionName">Target microservice function name</param>
        public MicroServiceEndPoint(string _MicroServiceName, string _FunctionGroupName, string _FunctionName)
        {
            m_MicroServiceName = _MicroServiceName.Trim().Replace(':', '.').ToLowerInvariant();
            m_FunctionGroupName = _FunctionGroupName.Trim().Replace(':', '.').ToLowerInvariant();
            m_FunctionName = _FunctionName.Trim().Replace(':', '.').ToLowerInvariant();
            CalculateHashCodeAndRoutingKey();
        }
        private string m_MicroServiceName;
        private string m_FunctionGroupName;
        private string m_FunctionName;

        private string m_RoutingKey;
        private int m_CachedHashCode;

        /// <summary>
        /// Microservice name
        /// Note: this is a lower case trimmed invariant culture string
        /// </summary>
        public string MicroServiceName
        {
            get
            {
                return m_MicroServiceName;
            }
        }

        /// <summary>
        /// Function group name within specified micro service <see cref="MicroServiceName"/>
        /// Note: this is a lower case trimmed invariant culture string
        /// </summary>
        public string FunctionGroupName
        {
            get
            {
                return m_FunctionGroupName;
            }
        }

        /// <summary>
        /// Function name within specified micro service function group <see cref="MicroServiceName"/> and <see cref="FunctionGroupName"/>
        /// Note: this is a lower case trimmed invariant culture string
        /// </summary>
        public string FunctionName
        {
            get
            {
                return m_FunctionName;
            }
        }

        /// <summary>
        /// Routing Key which is in the format string.concat(<see cref="MicroServiceName"/>, @":", <see cref="FunctionGroupName"/>, @":", <see cref="FunctionName"/>)
        /// Note: this is a lower case trimmed invariant culture string
        /// </summary>
        public string RoutingKey
        {
            get
            {
                return m_RoutingKey;
            }
        }

        /// <summary>
        /// Pre-calculated hashcode. This value is calculated by constructor
        /// and also whenever the routing key is changed <see cref="RoutingKey"/> is changed by changing either <see cref="MicroServiceName"/> or <see cref="FunctionGroupName"/> or <see cref="FunctionName"/>
        /// </summary>
        public int CachedHashCode
        {
            get
            {
                return m_CachedHashCode;
            }
        }

        /// <summary>
        /// Assign new value for micro service name <see cref="MicroServiceName"/>
        /// Note: character : is not allowed and will be replaced by .
        /// Note: value will be trimmed and cast to a lower case invariant culture string
        /// </summary>
        /// <param name="_MicroServiceName"></param>
        public void AssignMicroServiceName(string _MicroServiceName)
        {
            bool IsChanged;
            _MicroServiceName = _MicroServiceName.Trim().Replace(':','.').ToLowerInvariant();
            IsChanged = (_MicroServiceName != m_MicroServiceName);
            m_MicroServiceName = _MicroServiceName;
            if (IsChanged)
            {
                CalculateHashCodeAndRoutingKey();
            }
        }

        /// <summary>
        /// Assign new value for micro service function group name <see cref="FunctionGroupName"/>
        /// Note: character : is not allowed and will be replaced by .
        /// Note: value will be trimmed and cast to a lower case invariant culture string
        /// </summary>
        /// <param name="_FunctionGroupName"></param>
        public void AssignFunctionGroupName(string _FunctionGroupName)
        {
            bool IsChanged;
            _FunctionGroupName = _FunctionGroupName.Trim().Replace(':','.').ToLowerInvariant();
            IsChanged = (_FunctionGroupName != m_FunctionGroupName);
            m_FunctionGroupName = _FunctionGroupName;
            if (IsChanged)
            {
                CalculateHashCodeAndRoutingKey();
            }
        }

        /// <summary>
        /// Assign new value for function name within specified micro service function group <see cref="MicroServiceName"/> and <see cref="FunctionGroupName"/>
        /// Note: character : is not allowed and will be replaced by .
        /// Note: value will be trimmed and cast to a lower case invariant culture string
        /// </summary>
        /// <param name="_FunctionName"></param>
        public void AssignFunctionName(string _FunctionName)
        {
            bool IsChanged;
            _FunctionName = _FunctionName.Trim().Replace(':', '.').ToLowerInvariant();
            IsChanged = (_FunctionName != m_FunctionName);
            m_FunctionName = _FunctionName;
            if (IsChanged)
            {
                CalculateHashCodeAndRoutingKey();
            }
        }

        /// <summary>
        /// Calculate routing key and cached hashcode see <see cref="RoutingKey"/> and <see cref="CachedHashCode"/>
        /// </summary>
        private void CalculateHashCodeAndRoutingKey()
        {
            m_RoutingKey = string.Concat(MicroServiceName, @":", FunctionGroupName, @":", FunctionName);
            m_CachedHashCode = m_RoutingKey.GetHashCode();
        }

        /// <summary>
        /// Hashcode of routing key <see cref="RoutingKey"/>
        /// Note: this is pre-calculated when the routing key parameters are assigned and cached.
        /// Note: Pre-calculation and caching is for performance reasons - consider when this class is used as a key in hashtables
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return m_CachedHashCode;
        }

        /// <summary>
        /// Convenience method - Creates new instance of MicroServiceEndPoint using enumeration values specified as generics types
        /// </summary>
        /// <typeparam name="TMicroService">MicroService type enumeration</typeparam>
        /// <typeparam name="TFunctionGroup">MicroService function group type enumeration</typeparam>
        /// <typeparam name="TFunction">MicroService function group - function type enumeration</typeparam>
        /// <param name="MicroService">MicroService type enumeration value <see cref="MicroServiceName"/></param>
        /// <param name="FunctionGroup">MicroService function group type enumeration value <see cref="FunctionGroupName"/></param>
        /// <param name="Function">MicroService function group - function type enumeration value <see cref="FunctionName"/></param>
        /// <returns>New instance of MicroServiceEndPoint initialized using specified values</returns>
        public static MicroServiceEndPoint Create<TMicroService, TFunctionGroup, TFunction>(TMicroService MicroService, TFunctionGroup FunctionGroup, TFunction Function)
            where TMicroService : struct, IConvertible, IComparable, IFormattable
            where TFunctionGroup : struct, IConvertible, IComparable, IFormattable
            where TFunction : struct, IConvertible, IComparable, IFormattable
        {
            return new MicroServiceEndPoint(Enum.GetName(typeof(TMicroService), MicroService), (Enum.GetName(typeof(TFunctionGroup), FunctionGroup)), (Enum.GetName(typeof(TFunction), Function)));
        }
    }
}
