using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SensorSimulations.Models
{
    public class SensorType : INotifyPropertyChanged
    {
        public SensorType(Enums.SensorType type)
        {
            this.Type = type;
            System.Diagnostics.Debug.WriteLine("Nowy Sensor");
            switch (type)
            {
                case Enums.SensorType.AMR:
                    {
                        this.Name = "Anisotropic magnetoresistance";
                        this.Id = (int)Enums.SensorType.AMR;
                        System.Diagnostics.Debug.WriteLine(this.Name);
                        break;
                    }
                case Enums.SensorType.GMR:
                    {
                        this.Name = "Giant magnetoresistance";
                        this.Id = (int)Enums.SensorType.GMR;
                        break;
                    }
                case Enums.SensorType.TMR:
                    {
                        this.Name = "Tunnel magnetoresistance";
                        this.Id = (int)Enums.SensorType.TMR;
                        break;
                    }
                default:
                    break;
            }

            
        }

        private int _Id;
        private string _Name;
        private Enums.SensorType _Type;


        public int Id 
        {
            get 
            { 
                return _Id; 
            } 
            set 
            { 
                _Id = value; 
                NotifyPropertyChanged("Id"); 
            } 
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public Enums.SensorType Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
                NotifyPropertyChanged("Type");
            }
        }

        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion
    }
}
