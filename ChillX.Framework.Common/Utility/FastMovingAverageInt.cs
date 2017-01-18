using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.Utility
{
    /// <summary>
    /// Fast low CPU usage moving average based on integer math
    /// Note: This algorithm cannot be implemented for floating point because of cumulative floating point error
    /// </summary>
    public class FastMovingAverageInt
    {
        /// <summary>
        /// Initializes moving average for specified window size
        /// </summary>
        /// <param name="_WindowSize">Size of moving average windows</param>
        public FastMovingAverageInt(int _WindowSize)
        {
            if (_WindowSize < 2)
            {
                _WindowSize = 2;
            }
            m_WindowSize = _WindowSize;
        }
        private object SyncRoot = new object();
        private Queue<int> Buffer = new Queue<int>();
        private int m_WindowSize;
        private int m_MovingAverage = 0;
        private int MovingSum = 0;
        private bool BufferFull;

        /// <summary>
        /// Calculated moving average
        /// </summary>
        public int MovingAverage
        {
            get
            {
                lock (SyncRoot)
                {
                    return m_MovingAverage;
                }
            }
        }

        /// <summary>
        /// Size of moving average window set by constructor during intialization
        /// </summary>
        public int WindowSize
        {
            get
            {
                return m_WindowSize;
            }
        }

        /// <summary>
        /// Add new value to sequence and recalculate moving average seee <see cref="MovingAverage"/>
        /// </summary>
        /// <param name="NewValue">New value to be added</param>
        public void AddValue(int NewValue)
        {
            lock (SyncRoot)
            {
                Buffer.Enqueue(NewValue);
                MovingSum += NewValue;
                if (!BufferFull)
                {
                    int BufferSize = Buffer.Count;
                    BufferFull = BufferSize == WindowSize;
                    m_MovingAverage = MovingSum / BufferSize;
                }
                else
                {
                    MovingSum -= Buffer.Dequeue();
                    m_MovingAverage = MovingSum / WindowSize;
                }
            }
        }
    }
}
