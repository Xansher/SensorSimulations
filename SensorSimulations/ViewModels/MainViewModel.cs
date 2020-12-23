using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorSimulations.Models;


namespace SensorSimulations.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {

            ObservableCollection< Models.SensorType> output = new ObservableCollection<Models.SensorType>();
            output.Add(new SensorType(Enums.SensorType.AMR));
            output.Add(new SensorType(Enums.SensorType.GMR));
            output.Add(new SensorType(Enums.SensorType.TMR));

            
            SensorTypes = output;
            

        }

        private ObservableCollection<Models.SensorType> _SensorTypes;
        public ObservableCollection<Models.SensorType> SensorTypes
        {
            get
            {
                return _SensorTypes;
            }
            set
            {
                _SensorTypes = value;
                //NotifyPropertyChanged("SensorTypes");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                ((INotifyPropertyChanged)SensorTypes).PropertyChanged += value;
            }

            remove
            {
                ((INotifyPropertyChanged)SensorTypes).PropertyChanged -= value;
                
            }

            
        }


        /*public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
        
        
        public void NotifyPropertyChanged(ObservableCollection<SensorType> list)
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(this, list);
            }
        }*/







    }

    
    

}
