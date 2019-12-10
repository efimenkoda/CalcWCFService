using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My05_WPF_UI.CalcBusinessLogicProxy;
using My03_BusinessLogic;

namespace My2_UnitTests
{
    [TestClass]
    public class ProxyBusinessLogicTests
    {
        [TestMethod]
        public void TestProxy()
        {
            CalcBusinessLogicClient proxy = new CalcBusinessLogicClient("TCPEndpoint");
            proxy.Minus(1, 2);
            proxy.Plus(1, 2);
            List<CalcDTO> result = proxy.GetLog().ToList();          
            Console.WriteLine(result.Count());

        }

    }
}
