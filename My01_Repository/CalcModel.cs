using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

// Install-Package entityFramework -version 6.2.0
[assembly: InternalsVisibleTo("My2_UnitTests")] //для Unit-теста
namespace My01_Repository
{
    public class Calculation
    {
        [Key]
        public int CalcID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public string Operation { get; set; }
        public DateTime CreateDate { get; set; }
        public Calculation()
        {
            CreateDate = DateTime.Now;
        }
    }

    
    class CalcContext:DbContext
    {
        public CalcContext():base("name=CalculationLogConnectionString")
        {
            Database.SetInitializer<CalcContext>(null);
        }

        public CalcContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer<CalcContext>(null);
        }



        public virtual DbSet<Calculation> Calculations { get; set; }
    }
}
