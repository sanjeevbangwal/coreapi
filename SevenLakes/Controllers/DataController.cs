using Microsoft.AspNetCore.Mvc;
using Rest.Management.Business.Interface;
using Rest.Management.Common.Request;
using Rest.Management.Common.Response;
using System.Collections.Generic;

namespace Rest.Management.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {


        private readonly IDataBusiness dataBusiness;

        public DataController(IDataBusiness dataBusiness)
        {
            this.dataBusiness = dataBusiness;
        }

        [HttpPost]
        public IEnumerable<DataResponse> ReadData(List<RouteRequest> routeRequests)
        {
            return dataBusiness.ReadData(routeRequests);
        }
    }
}
