using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorSimulations.Models
{
    public class Sensor
    {
        private int _Id;
        private Enums.SensorType _Type;
        private string _Name;
        private Parameter _MaxSupplyVoltage;
        private Parameter _Resistance;
        private Parameter _Sensitivity;
        private Parameter _MinSatField;
        private Parameter _MaxSatField;
        private Parameter _LinearityRange;
        private Parameter _NonLinearity;
        private Parameter _Hysteresis;
        private Parameter _MaxOffset;

        public Sensor()
        {

        }



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

        public Enums.SensorType Type
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

        public Parameter MaxSupplyVoltage
        {
            get
            {
                return _MaxSupplyVoltage;
            }
            set
            {
                _MaxSupplyVoltage = value;
            }
        }

        public Parameter Resistance
        {
            get
            {
                return _Resistance;
            }
            set
            {
                _Resistance = value;
            }
        }

        public Parameter Sensitivity
        {
            get
            {
                return _Sensitivity;
            }
            set
            {
                _Sensitivity = value;
            }
        }

        public Parameter MinSatField
        {
            get
            {
                return _MinSatField;
            }
            set
            {
                _MinSatField = value;
            }
        }

        public Parameter MaxSatField
        {
            get
            {
                return _MaxSatField;
            }
            set
            {
                _MaxSatField = value;
            }
        }

        public Parameter LinearityRange
        {
            get
            {
                return _LinearityRange;
            }
            set
            {
                _LinearityRange = value;
            }
        }

        public Parameter NonLinearity
        {
            get
            {
                return _NonLinearity;
            }
            set
            {
                _NonLinearity = value;
            }
        }

        public Parameter Hysteresis
        {
            get
            {
                return _Hysteresis;
            }
            set
            {
                _Hysteresis = value;
            }
        }

        public Parameter MaxOffset
        {
            get
            {
                return _MaxOffset;
            }
            set
            {
                _MaxOffset = value;
            }
        }

    }



}
