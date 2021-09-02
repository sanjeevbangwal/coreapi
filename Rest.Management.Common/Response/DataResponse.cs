using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Management.Common.Response
{
    public class DataResponse
    {
        public string ObjectType { get; set; }
        public string ObjectName { get; set; }
        public string StopName { get; set; }
        public string RouteName { get; set; }
    }
}
