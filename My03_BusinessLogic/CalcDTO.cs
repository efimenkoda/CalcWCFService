using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My03_BusinessLogic
{

    public class CalcDTO
    {        
        public int CalcID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public string Operation { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
