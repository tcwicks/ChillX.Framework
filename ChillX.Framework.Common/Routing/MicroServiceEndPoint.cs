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
        }
        /// <summary>
        /// Initializes this MicroServiceEndPoint with specified values for all parameters <see cref="MicroServiceName"/>, <see cref="FunctionGroupName"/>, <see cref="FunctionName"/>;
        /// </summary>
        /// <param name="_MicroServiceName">Target microservice name</param>
        /// <param name="_FunctionGroupName">Target microservice function group name</param>
        /// <param name="_FunctionName">Target microservice function name</param>
        public MicroServiceEndPoint(string _MicroServiceName, string _FunctionGroupName, string _FunctionName)
        {
            m_MicroServiceName = _MicroServiceName;
            m_FunctionGroupName = _FunctionGroupName;
            m_FunctionName = _FunctionName;
        }
        private string m_MicroServiceName;
        private string m_FunctionGroupName;
        private string m_FunctionName;

        /// <summary>
        /// Microservice name
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
        /// </summary>
        public string FunctionName
        {
            get
            {
                return m_FunctionName;
            }
        }

        /// <summary>
        /// Assign new value for micro service name <see cref="MicroServiceName"/>
        /// </summary>
        /// <param name="_MicroServiceName"></param>
        public void AssignMicroServiceName(string _MicroServiceName)
        {
            m_MicroServiceName = _MicroServiceName;
        }

        /// <summary>
        /// Assign new value for micro service function group name <see cref="FunctionGroupName"/>
        /// </summary>
        /// <param name="_FunctionGroupName"></param>
        public void AssignFunctionGroupName(string _FunctionGroupName)
        {
            m_FunctionGroupName = _FunctionGroupName;
        }

        /// <summary>
        /// Assign new value for function name within specified micro service function group <see cref="MicroServiceName"/> and <see cref="FunctionGroupName"/>
        /// </summary>
        /// <param name="_FunctionName"></param>
        public void AssignFunctionName(string _FunctionName)
        {
            m_FunctionName = _FunctionName;
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
