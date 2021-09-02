using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Management.Common.Request
{
   public class StopRequest
    {
        public string StopName { get; set; }

        public List<DataObject> Objects { get; set; }
    }
}
