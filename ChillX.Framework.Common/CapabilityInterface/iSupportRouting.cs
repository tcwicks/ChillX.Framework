using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillX.Framework.Common.CapabilityInterface
{
    public interface ISupportRouting
    {
        DateTime CreationDate { get; set; }
        ISupportRoutingContentType RoutingContentType { get; }
        ISupportRoutingMicroService RoutingMicroService { get; }
        ISupportUniqueID RoutingSourceEndPoint { get; }
    }
}
