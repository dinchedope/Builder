using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneCore
{
    public class AirPlane
    {
        public float wingsLength { get; set; }
        public float motorPower { get; set; }
        public int seetingCount { get; set; }

        public override string ToString()
        {
            return $"Wings Length: {wingsLength}\nMotor Power : {motorPower}\nSeeting Count : {seetingCount}";
        }
    }
}
