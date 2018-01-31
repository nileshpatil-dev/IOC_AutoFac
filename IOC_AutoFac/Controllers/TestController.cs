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
        private ITest1 _test1;
        public TestController(ITestService testService, ITest1 test1)
        {
            _testService = testService;
            _test1 = test1;
        }
        public string GetGreetings() {
            // return _testService.GetGreetings();
            return _test1.TestMethod();
        }
    }
}
