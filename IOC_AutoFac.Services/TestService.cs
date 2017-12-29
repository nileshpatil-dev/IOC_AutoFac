using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_AutoFac.Services
{
    public class TestService : ITestService
    {
        public string GetGreetings() {
            return "Hello";
        }
    }
}
