using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Management.Common.Request
{
 public   class RouteRequest
    {
        public string RouteName { get; set; }

        public List<StopRequest> Stops { get; set; }
    }
}
