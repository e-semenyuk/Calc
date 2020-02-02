using Model;
using Ninject;

namespace Presentation
{
    public class CalcPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICalcView _view;
        private readonly ICalcService _service;

        public CalcPresenter(IKernel kernel, ICalcView view, ICalcService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Calculate += Calculate;
            _view.GetValues += GetValues;
            _view.GetInitialValues += GetInitialValues;
        }

        public void Calculate(double[] values, double value, string operation)
        {
            _service.Calculate(values, value, operation);
            _service.ConvertToString();
        }
        public string GetValues()
        {
            return _service.StringValues;
        }
        public string GetInitialValues()
        {
            return _service.InitianlValues;
        }
        public void Run(string values)
        {
            _view.Show(values);
        }
    }
}
