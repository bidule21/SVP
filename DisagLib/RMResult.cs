using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisagLib
{
    /*
        WSC=1K
        STAF
        SCH=1;9.0;460.0;222.3;G7
        SCH=2;10.0;120.0;170.7;G-
        SCH=3;10.0;73.0;347.8;G2
        SCH=4;9.0;370.0;295.1;G:
        SCH=5;9.0;282.0;231.6;G>
        SCH=6;10.0;151.0;147.1;G-
        SCH=7;10.0;76.0;202.0;G; Teilerwert abstand von 10
        SCH=8;10.0;140.0;160.3;G$
        SCH=9;10.0;193.0;202.2;G-
        SCH=10;10.0;131.0;50.7;G-
        WSEA
    */
    public class RMResult
    {
        public int ShotNumber;
        public double Rings;
        public double FactorValue;
        public double Angle;
        public ValidFlag Validity;
    }
    public enum ValidFlag
    {
        Valid,
        NotValid,
        HasToBeChecked
    }
}
