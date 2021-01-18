using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SensorSimulations
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);
            ViewModels.MainViewModel VM = new ViewModels.MainViewModel();
            MainWindow window = new MainWindow(VM);
            window.DataContext = VM;
            window.Show();

            
        }
    }
}
