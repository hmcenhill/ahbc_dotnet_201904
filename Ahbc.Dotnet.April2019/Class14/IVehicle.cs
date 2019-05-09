using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public interface IVehicle : IBrake, IHonk
    {
        void Drive(string speed);
    }
}
