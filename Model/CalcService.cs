using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CalcService : ICalcService
    {
        public string InitianlValues { get; set; }
        public string StringValues { get; set; }
        public double[] Values { get; set; }
        public void Calculate(double[] values, double value, string operation)
        {
            for (int i = 0; i < values.Length; i++)
            {
                switch (operation)
                {
                    case "Прибавить":
                        values[i] += value;
                        break;
                    case "Отнять":
                        values[i] -= value;
                        break;
                    default:
                        break;
                }
            }
            Values = values;
        }
        public void ConvertToString()
        {
                StringValues = string.Join("; ", Values);
            
        }
        private double GetFactorial(double n)
        {
            double res = 1;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            return res;
        }
        public void SetIniticalValues(string values)
        {
            InitianlValues = values;
        }
    }
}
