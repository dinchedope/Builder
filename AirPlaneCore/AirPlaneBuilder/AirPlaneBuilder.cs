using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneCore
{
    public class AirPlaneBuilder : IAirPlaneBuilder
    {
        AirPlane airPlane;

        public AirPlaneBuilder()
        {
            this.airPlane = new AirPlane();
        }

        IAirPlaneBuilder IAirPlaneBuilder.SetMotorPower(float motorPower)
        {
            airPlane.motorPower = motorPower;
            return this;
        }

        IAirPlaneBuilder IAirPlaneBuilder.SetSeetingCount(int seetingCount)
        {
            airPlane.seetingCount = seetingCount;
            return this;
        }

        IAirPlaneBuilder IAirPlaneBuilder.SetWingthLength(float wingsLength)
        {
            airPlane.wingsLength = wingsLength;
            return this;
        }

        public AirPlane GetAirPlane()
        {
            AirPlane _airPlane = airPlane;

            airPlane = null;

            return _airPlane;
        }
    }
}
