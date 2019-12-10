using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My03_BusinessLogic;
using My01_Repository;
namespace My2_UnitTests
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void TestAll()
        {
            CalcBusinessLogic logic = new CalcBusinessLogic();
            var result = logic.Plus(111, 222);
            
            Console.WriteLine(logic.GetLog().Count());
        }





    }
}
