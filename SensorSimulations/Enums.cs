using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorSimulations
{
    public class Enums
    {
        public enum SensorType 
        { 
            AMR = 0,
            GMR = 1,
            TMR = 2
        }
        public enum LoadingType
        {
            Catalog = 0,
            Manual = 1,
            Curve = 2
        }
        /*public enum BaseUnit
        {
            m =1,
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
        }*/
    }
}
