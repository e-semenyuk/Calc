using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICalcService
    {
        string InitialValues { get; set; }
        string StringValues { get; set; }
        double[] Values { get; set; }
        void Calculate(double[] values, double value, string operation);
        void ConvertToString();
    }
}
