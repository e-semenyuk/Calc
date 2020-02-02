using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ICalcView : IView
    {
        event Delegates.Calculate Calculate;
        event Delegates.GetValues GetValues;
        event Delegates.GetInitialValues GetInitialValues;
        void ShowError(string message);
    }
}
