using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My01_Repository;
using System.Linq;
using System.Runtime.CompilerServices;


namespace My2_UnitTests
{
    [TestClass]
    public class UnitTestRepository
    {
        [TestMethod]
        public void TestCalcContext()
        {
            using (CalcContext context = new CalcContext())
            {
                for (int i = 0; i < 100; i++)
                {
                    Calculation c = new Calculation() { 
                        X = i, 
                        Y = i+1, 
                        Z = 2*i+1, 
                        Operation = "plus",
                        CreateDate=DateTime.Now.AddDays(-i)
                    };
                    context.Calculations.Add(c);
                    context.SaveChanges();
                }
                
                
            }
        }

        [TestMethod]
        public void TestRepository()
        {
            Repository repository = new Repository();
            Calculation c = new Calculation()
            {
                X = 111,
                Y = 222,
                Z = 333,
                Operation = "plus",
            };
            repository.Log(c);

            c = repository.GetLog().Last();
            Assert.AreEqual(333, c.Z);
        }

        [TestMethod]
        public void GetLogFilteredTest()
        {
            using (CalcContext context = new CalcContext())
            {
                Repository repo = new Repository();
                

                Calculation c = new Calculation()
                {
                    X = 123,
                    Y = 100,
                    Z = 23,
                    Operation = "minus",                    
                };
                repo.Log(c);
                // c = repo.GetLogFiltered(op => op.Operation=="minus" && op.Z==23).Last(); 
                //Assert.AreEqual(23, c.Z);

                var c1 = repo.GetLogFiltered(op => op.CreateDate < DateTime.Now).ToList();
                Console.WriteLine(c1.Count());
                
            }
        }
    }
}
