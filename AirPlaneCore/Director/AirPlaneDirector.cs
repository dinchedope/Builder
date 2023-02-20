using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlaneCore
{
    public class AirPlaneDirector
    {
        private readonly IAirPlaneBuilder _builder;
        public AirPlaneDirector(IAirPlaneBuilder _builder)
        {
            this._builder = _builder;
        }

        public void Build(float wingsLength, float motorPower, int seetingcount)
        {
            _builder.SetWingthLength(wingsLength).SetSeetingCount(seetingcount).SetMotorPower(motorPower);
        }
    }
}
