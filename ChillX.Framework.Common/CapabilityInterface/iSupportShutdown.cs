using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportShutdown
    {
        bool IsShutdown { get; }
        void Startup();
        void Shutdown();
    }
}
