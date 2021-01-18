using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorSimulations.Models
{
    public class Parameter
    {
        private double _Value;
        private string _Label;
        private Unit _Unit;

        public Parameter(string label, double value, Unit unit)
        {
            Label = label;
            Value = value;
            Unit = unit;
        }

        public double Value
        {
            get 
            { 
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        public string Label
        {
            get
            {
                return _Label;
            }
            set
            {
                _Label = value;
            }
        }
        public Unit Unit
        {
            get
            {
                return _Unit;
            }
            set
            {
                _Unit = value;
            }
        }
    }


    
}
