using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ColorViewer.ModelViewers;
using ColorViewer.Views;

namespace ColorViewer
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>

    internal partial class App : Application
    {
        public App()
        {
            Startup += AppStarup;
        }
        
        public void AppStarup(object sender, StartupEventArgs e)
        {
            var viewModel = new MainViewModel();
            var view = new MainWindow(viewModel);

            view.Show();
        }
    }
}
