using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorSimulations.Models
{
    public enum BaseUnit
    {
        m = 1,
        g,
        s,
        A,
        K,
        mol,
        cd
    }
    public enum Prefix
    {
        y = -24,
        z = -21,
        a = -18,
        f = -15,
        p = -12,
        n = -9,
        u = -6,
        m = -3,
        c = -2,
        d = -1,
        da = 1,
        h = 2,
        k = 3,
        M = 6,
        G = 9,
        T = 12,
        P = 15,
        E = 18,
        Z = 21,
        Y = 24
    }

    public class Unit
    {
        private BaseUnit _BaseUnit;
        private Prefix _Prefix;
        private sbyte _Power; 
        public Unit( Prefix prefix, BaseUnit baseUnit, sbyte power)
        {
            this.Prefix = prefix;
            this.BaseUnit = baseUnit;
            this.Power = power;
        }

        public Unit(string test)
        {
            // kg^2


        }

        public BaseUnit BaseUnit
        {
            get
            {
                return _BaseUnit;
            }
            set
            {
                _BaseUnit = value;
            }
        }
        
        public Prefix Prefix
        {
            get
            {
                return _Prefix;
            }
            set
            {
                _Prefix = value;
            }
        }

        public sbyte Power
        {
            get
            {
                return _Power;
            }
            set
            {
                _Power = value;
            }
        }

        public override string ToString()
        {
            
            return Prefix.ToString() + BaseUnit.ToString() + "^" + Power.ToString(); 

        }
    }
}
