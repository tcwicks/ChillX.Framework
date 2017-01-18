using ChillX.Framework.Common.WorkItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Transport
{
    public abstract class TransportConnectionBase
    {
        /// <summary>
        /// Constructor iniitilizes this instance with specified WorkItemHandler for recieved work items
        /// </summary>
        /// <param name="_RECV">WorkItemHandler delegate for processing recieved work items</param>
        public TransportConnectionBase(WorkItemHandler _RECV)
        {
            RECV = _RECV;
        }
        private object SyncRoot = new object();
        private WorkItemHandler RECV;
        private bool m_IsReady = false;
        private bool m_IsTerminated = false;

        /// <summary>
        /// Is ready for transmit and recieve functions.
        /// This is set to true once the connection is established and functional.
        /// </summary>
        public bool IsReady
        {
            get
            {
                lock (SyncRoot)
                {
                    return m_IsReady;
                }
            }
        }

        /// <summary>
        /// Is connection terminated. Once this is set to true the transport will remove and dispose of this connection
        /// </summary>
        public bool IsTerminated
        {
            get
            {
                lock (SyncRoot)
                {
                    return m_IsTerminated;
                }
            }
        }

        /// <summary>
        /// Should be called by concrete class to signal connection is ready for processing messages
        /// </summary>
        /// <param name="_IsReady">Is Ready Status</param>
        protected void AssignReadyStatus(bool _IsReady)
        {
            lock (SyncRoot)
            {
                m_IsReady = _IsReady;
            }
        }

        /// <summary>
        /// Should be called by concrete class when connection is terminated.
        /// Note: this will set the IsTerminated flag to true see <see cref="IsTerminated"/>
        /// </summary>
        protected void AssignTerminatedStatus()
        {
            lock (SyncRoot)
            {
                m_IsTerminated = true;
                m_IsReady = false;
            }
        }

        /// <summary>
        /// Transmit work item to remote end
        /// </summary>
        /// <param name="WorkItemInstance">Work item to be transmitted</param>
        /// <returns>Success / Failure</returns>
        public bool XMIT(IWorkItem WorkItemInstance)
        {
            if (IsReady) { return OnXMIT(WorkItemInstance); }
            return false;
        }

        /// <summary>
        /// Abstract method for concrete class override to implement logic for transmitting work item to remote end
        /// </summary>
        /// <param name="WorkItemInstance">Work item to be transmitted</param>
        /// <returns>Success / Failure</returns>
        protected abstract bool OnXMIT(IWorkItem WorkItemInstance);

        /// <summary>
        /// Proxy method for processing recieved work items.
        /// The work item will be handed off to the WorkItemHandler delegate specified when creating the instance of this class
        /// </summary>
        /// <param name="WorkItemInstance"></param>
        /// <returns></returns>
        protected bool OnRECV(IWorkItem WorkItemInstance)
        {
            return RECV(WorkItemInstance);
        }
    }
}
