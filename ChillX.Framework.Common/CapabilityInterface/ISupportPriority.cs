using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportPriority<TPriorityEnum>
        where TPriorityEnum : struct, IComparable, IFormattable, IConvertible
    {
        TPriorityEnum Priority { get; }
        void AssignPriority(TPriorityEnum _Priority);
    }
}
