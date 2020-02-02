using Model;
using Ninject;
using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ILaunchView>().To<Form1>();
            kernel.Bind<ICalcView>().To<Form2>();
            kernel.Bind<CalcPresenter>().ToSelf();
            kernel.Bind<LaunchPresenter>().ToSelf();
            kernel.Bind<ICalcService>().To<CalcService>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<LaunchPresenter>().Run("");
            Application.Run(kernel.Get<ApplicationContext>());
/*            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
