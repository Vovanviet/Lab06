using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    public class Thermostat
    {
        public delegate void TemperatureChangeHandle(float newTemperature);
        private TemperatureChangeHandle _OnTemperatureChange;
        public TemperatureChangeHandle OnTemperatureChange
        {
            get { return _OnTemperatureChange; }
            set { _OnTemperatureChange = value; }
        }
        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    if (OnTemperatureChange != null)
                    {
                        OnTemperatureChange(value);
                    }
                }

            }

        }
        private float _CurrentTemperature;

    }
}
