using ChillX.Framework.Common.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.WorkItem
{
    public delegate bool WorkItemHandler(IWorkItem WorkItemInstance);
    [Serializable]
    public class WorkItem : RoutableMessageBase, IWorkItem
    {

    }
}
