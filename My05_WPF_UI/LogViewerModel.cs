using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My05_WPF_UI.CalcBusinessLogicProxy;
using My03_BusinessLogic;


namespace My05_WPF_UI
{
    public class LogViewerModel
    {
        
        public List<CalcDTO> Data { get; set; }
        public List<CalcDTO> DataFiltered { get; set; }

        public int Count { get; set; }
        

    
        private CalcBusinessLogicClient proxy;
        public LogViewerModel()
        {
            proxy = new CalcBusinessLogicClient("TCPEndpoint");
            Data = proxy.GetLog().ToList();
            Count = Data.Count();
        }

        public List<CalcDTO> GetLogFiltered(DateTime dateStart, DateTime dateEnd)
        {       
           
            return proxy.GetLogDates(dateStart, dateEnd).ToList();
        }


    }
}
