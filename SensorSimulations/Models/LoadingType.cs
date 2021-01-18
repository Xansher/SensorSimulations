using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorSimulations.Models
{
    public class LoadingType
    {
        public LoadingType(Enums.LoadingType type)
        {
            this.Type = type;

            switch (type)
            {
                case Enums.LoadingType.Catalog:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    } 
            }
        }

        private int _Id;
        private string _Name;
        private Enums.LoadingType _Type;


        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;              
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
            }
        }

        public Enums.LoadingType Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
    }
}
