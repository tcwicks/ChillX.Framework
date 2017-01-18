using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportCopyTyped<T>
    {
        T DeepCopyTyped();
        bool DeepCopyToTyped(T Other);
        T ShallowCopyTyped();
        bool ShallowCopyToTyped(T Other);
    }
}
