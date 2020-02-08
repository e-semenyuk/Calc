using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IView
    {
        void Show();
        void Close();
    }

    public static class Delegates
    {
        public delegate void Calculate(double[] values, double value, string operation);
        public delegate string GetValues();
        public delegate string GetInitialValues();
        public delegate void Launch(string values);
    }
}
