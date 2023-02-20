using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneCore
{
    public interface IAirPlaneBuilder
    {
        IAirPlaneBuilder SetWingthLength(float wingsLength);

        IAirPlaneBuilder SetMotorPower(float motorPower);

        IAirPlaneBuilder SetSeetingCount(int seetingCount);
    }
}
