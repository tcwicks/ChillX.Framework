using ChillX.Framework.Common.Utility;
using ChillX.Framework.Common.WorkItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Transport
{
    public abstract class TransportConnectionBase : IDisposable
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
        private Byte m_TransportCost = 0;
        private FastMovingAverageInt LatencyMovingAverage = new FastMovingAverageInt(10);

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
        /// Transport cost wieghting. Will be used by transport server when multiple transports are available for a given destination.
        /// Lower weight transports will be prefered over higher weight transports.
        /// </summary>
        public Byte TransportCost
        {
            get
            {
                return m_TransportCost;
            }
        }

        /// <summary>
        /// Xmit latency of this connection. Moving average of last 10 transmissions
        /// Note: This value is used by the transport server when multiple transports are available for a given destination.
        /// For the same transport cost see <see cref="TransportCost"/> Lower latency transports will be prefered over higher latency transports.
        /// </summary>
        public int LatencyMS
        {
            get
            {
                return LatencyMovingAverage.MovingAverage;
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
        /// Should be called by concrete class during initialization to set transport cost value see <see cref="TransportCost"/>
        /// </summary>
        /// <param name="Cost"></param>
        protected void AssignTransportCost(Byte Cost)
        {
            m_TransportCost = Cost;
        }

        /// <summary>
        /// Transmit work item to remote end
        /// </summary>
        /// <param name="WorkItemInstance">Work item to be transmitted</param>
        /// <returns>Success / Failure</returns>
        public bool XMIT(IWorkItem WorkItemInstance)
        {
            if (IsReady)
            {
                bool Result;
                DateTime StartTime = DateTime.Now;
                Result = OnXMIT(WorkItemInstance);
                LatencyMovingAverage.AddValue(Convert.ToInt32(DateTime.Now.Subtract(StartTime).TotalMilliseconds));
            }
            return false;
        }

        /// <summary>
        /// Abstract method for concrete class override to implement logic for transmitting work item to remote end
        /// Note: This method should NOT implement async behavior. For Async capable transports the transport server will initiate multiple parallel conecctions
        /// Note: This class should wrap a single end to end connection.
        /// Reason: Atomic message transmission and latency calculation depends on this.
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

        private bool m_IsDisposed = false;

        /// <summary>
        /// Dispose will be called by Transport server once connection is marked terminated by concrete class
        /// or if the transport server is closing the connection. Will also be called when the transport server is shutting down.
        /// </summary>
        public void Dispose()
        {
            if (!m_IsDisposed)
            {
                DoDispose();
            }
        }

        /// <summary>
        /// Override to be implemented in concrete class for cleanup.
        /// </summary>
        protected abstract void DoDispose();
    }
}
