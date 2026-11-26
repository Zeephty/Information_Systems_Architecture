using BLogic;
using BLogic.Interfaces;
using Ninject;
using Shared;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DataSourceKind currentKind = DataSourceKind.Json;
            IKernel kernel = new StandardKernel(new ConfigModule(currentKind));
            IObservableLogic logic = kernel.Get<IObservableLogic>();

            // ВАРИАНТ 1: Запуск WinForms представления
            // =================================================================
            ApplicationConfiguration.Initialize();

            var view = new WinForms.MainForm();
            var presenter = new RobotPresenter(view, logic);

            Application.Run(view);

            // ВАРИАНТ 2: Запуск Console представления 
            // =================================================================
            //var view = new ConsoleApp.ConsoleView();
            //var presenter = new RobotPresenter(view, logic);

            //view.RunMenu();
        }
    }
}
