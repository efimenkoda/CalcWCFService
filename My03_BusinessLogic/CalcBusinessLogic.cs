using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using My01_Repository;
using AutoMapper;

namespace My03_BusinessLogic
{
    [ServiceContract]
    public interface ICalcBusinessLogic
    {
        [OperationContract]
        int Plus(int x, int y);

        [OperationContract]
        int Minus(int x, int y);

        [OperationContract]
        List<CalcDTO> GetLog();

        [OperationContract]
        List<CalcDTO> GetLogDates(DateTime Timestapm1, DateTime Timestapm2);
    }
    public class CalcBusinessLogic:ICalcBusinessLogic
    {
        private IMapper mapper;
        public CalcBusinessLogic()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Calculation, CalcDTO>());
            mapper = new Mapper(config);
        }
        public int Plus(int x, int y)
        {
            Repository repo = new Repository();
            var result = x + y;
            repo.Log(new Calculation() { X = x, Y = y, Z = result, Operation = "plus" });
            return result;
        }

        public int Minus(int x, int y)
        {
            Repository repo = new Repository();
            var result = x - y;
            repo.Log(new Calculation() { X = x, Y = y, Z = result, Operation = "minus" });
            return result;
        }

        public List<CalcDTO> GetLog()
        {
            Repository repo = new Repository();
            return mapper.Map<List<CalcDTO>>(repo.GetLog());
 
        }
        
        public List<CalcDTO> GetLogDates(DateTime Timestamp1, DateTime Timestamp2)
        {
            Repository repo = new Repository();            
            return mapper.Map<List<CalcDTO>>(repo.GetLogFiltered(x=>x.CreateDate>=Timestamp1 && x.CreateDate<=Timestamp2));
        }
    }
}
