using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportPause
    {
        bool IsPaused { get; }
        void PauseExecution();
        void ResumeExecution();
    }
}
