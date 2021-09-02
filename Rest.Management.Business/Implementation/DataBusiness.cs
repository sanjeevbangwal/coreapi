using Rest.Management.Business.Interface;
using Rest.Management.Common.Request;
using Rest.Management.Common.Response;
using System.Collections.Generic;
using System.Linq;

namespace Rest.Management.Business.Implementation
{
    public class DataBusiness : IDataBusiness
    {
        public IEnumerable<DataResponse> ReadData(List<RouteRequest> routeRequests)
        {
            var data = routeRequests.SelectMany(x => x.Stops.
            SelectMany(y => y.Objects.
             Select(z => new DataResponse()
             {
                 ObjectName = z.ObjectName,
                 ObjectType = z.ObjectType,
                 StopName = y.StopName,
                 RouteName = x.RouteName
             })));
            return data;
        }

    }
}
