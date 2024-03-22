using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer UnityC;

            string _connectionString = "server=127.0.0.1;uid=root;pwd=1234;database=testcrud";

            UnityC = new UnityContainer()
                .RegisterType<IMainView, MainView>(new ContainerControlledLifetimeManager())
                .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IErrorMessageView, ErrorMessageView>(new ContainerControlledLifetimeManager());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainPresenter mainPresenter = UnityC.Resolve<MainPresenter>();
            IMainView mainView = mainPresenter.GetMainView(); 

            Application.Run((MainView)mainView);
        }
    }
}
