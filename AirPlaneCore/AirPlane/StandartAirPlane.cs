using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneCore
{
    public class StandartAirPlane : AirPlane
    {
        public override string ToString()
        {
            return $"Wings Length: {wingsLength}\nMotor Power : {motorPower}\nSeeting Count : {seetingCount}";
        }
    }
}
