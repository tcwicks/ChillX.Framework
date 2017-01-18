using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportCopy
    {
        object DeepCopy();
        bool DeepCopyTo(object Other);
        object ShallowCopy();
        bool ShallowCopyTo(object Other);
    }
}
