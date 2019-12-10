using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using My03_BusinessLogic;

namespace My04_BusinessLogicHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //без конфигурационного файла
            //ServiceHost host = new ServiceHost(typeof(CalcBusinessLogic),
            //    new Uri("http://localhost:7777/"));
            //host.AddServiceEndpoint(typeof(ICalcBusinessLogic), new WSHttpBinding(), "Calc");

            //с использованием конфигурационного файла
            ServiceHost host = new ServiceHost(typeof(CalcBusinessLogic));
            host.Open();
            Console.WriteLine("host is on...");
            Console.ReadKey();
        }
    }
}
