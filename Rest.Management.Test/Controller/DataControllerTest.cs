using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rest.Management.API.Controllers;
using Rest.Management.Business.Interface;
using Rest.Management.Common.Request;
using Rest.Management.Common.Response;
using System.Collections.Generic;
using System.Linq;

namespace Rest.Management.Test.Controller
{
    [TestClass]
   public class DataBusinessTest
    {
        Mock<IDataBusiness> dataBusiness;
        DataController dataController;

        [TestInitialize]
        public void Initialize()
        {
            dataBusiness = new Mock<IDataBusiness>();
            dataController = new DataController(dataBusiness.Object);
        }
        [TestCleanup]
        public void CleanUp()
        {
            dataBusiness = null;
            dataController = null;
        }
        [TestMethod]
        public void ReadData()
        {
            List<RouteRequest> routeRequests = new List<RouteRequest>();

            routeRequests.Add(new RouteRequest() { 
                RouteName = "RouteName", 
                Stops = new List<StopRequest>() { 
                    new StopRequest() { 
                        StopName = "StopName", 
                        Objects = new List<DataObject>() { 
                            new DataObject() { 
                                ObjectName = "obj",
                                ObjectType = "type"
                            }
                        } 
                    } 
                } 
            });
            var response = new List<DataResponse>() { 
                new DataResponse() { 
                    ObjectName="name",
                    ObjectType="type",
                    RouteName="routename",
                    StopName="name"
                } 
            };

            dataBusiness.Setup(x => x.ReadData(It.IsAny<List<RouteRequest>>())).Returns(response.AsEnumerable());
            var result= dataController.ReadData(routeRequests);

            Assert.IsTrue(result.Any());
        }
    }
}
