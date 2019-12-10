using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace My01_Repository
{
    public class Repository
    {
        public void Log(Calculation calculation)
        {
            using (CalcContext context=new CalcContext())
            {
                context.Calculations.Add(calculation);
                context.SaveChanges();
            }
        }

        public List<Calculation> GetLog()
        {
            using (CalcContext context = new CalcContext())
            {
                return context.Calculations.ToList();
            }
        }

        public List<Calculation> GetLogFiltered(Expression<Func<Calculation, bool>> func)
        {

            using (CalcContext context = new CalcContext())
            {

                return context.Calculations.Where(func).ToList();
            }
        }

    }
}
