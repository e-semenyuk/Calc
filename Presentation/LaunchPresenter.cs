using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class LaunchPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ILaunchView _view;
        private readonly ICalcService _service;

        public LaunchPresenter(IKernel kernel, ILaunchView view, ICalcService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;
            _view.Launch += Launch;
        }
        public void Launch(string values)
        {
            _service.InitialValues = values;

            _kernel.Get<CalcPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
