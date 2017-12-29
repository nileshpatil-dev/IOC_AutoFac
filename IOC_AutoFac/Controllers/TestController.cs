using IOC_AutoFac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IOC_AutoFac.Controllers
{
    public class TestController : ApiController
    {
        private ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }
        public string GetGreetings() {
            return _testService.GetGreetings();
        }
    }
}
