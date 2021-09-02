using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rest.Management.Business.Implementation;
using Rest.Management.Common.Request;
using System.Collections.Generic;
using System.Linq;

namespace Rest.Management.Test.Business
{
    [TestClass]
   public class DataBusinessTest
    {
        DataBusiness dataBusiness ;

        [TestInitialize]
        public void Initialize()
        {
            dataBusiness = new DataBusiness();
        }
        [TestMethod]
        public void ReadData()
        {
            List<RouteRequest> routeRequests = new List<RouteRequest>();

            routeRequests.Add(new RouteRequest() { RouteName = "RouteName", Stops = new List<StopRequest>() { new StopRequest() { StopName = "StopName", Objects = new List<DataObject>() { new DataObject() { ObjectName = "obj", ObjectType = "type" } } } } });

           var result= dataBusiness.ReadData(routeRequests);

            Assert.IsTrue(result.Any());
        }
    }
}
