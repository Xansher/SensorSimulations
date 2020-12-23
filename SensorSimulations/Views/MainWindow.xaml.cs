using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace SensorSimulations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModels.MainViewModel ViewModel;
        public MainWindow(ViewModels.MainViewModel m)
        {
            this.ViewModel = m;
            InitializeComponent();
            
        }

        private void Add(object sender, RoutedEventArgs e)
        {
             

            ObservableCollection<Models.SensorType> List = new ObservableCollection<Models.SensorType>();
            List.Add(new Models.SensorType(Enums.SensorType.AMR));

            // ViewModel.SensorTypes.CollectionChanged += SensorTypes_CollectionChanged;
            //ObservableCollectionExtensions.RemoveAll<Models.SensorType>(ViewModel.SensorTypes);
            ViewModel.SensorTypes.RemoveAll(x=>true);
           
            ViewModel.SensorTypes.Add(new Models.SensorType(Enums.SensorType.GMR));
        }

       /* private void SensorTypes_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }*/
    }
}
