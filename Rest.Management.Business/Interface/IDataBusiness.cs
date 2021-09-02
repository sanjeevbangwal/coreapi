using Rest.Management.Common.Request;
using Rest.Management.Common.Response;
using System.Collections.Generic;

namespace Rest.Management.Business.Interface
{

    public interface IDataBusiness
    {
        IEnumerable<DataResponse> ReadData(List<RouteRequest> routeRequests);
    }
}
