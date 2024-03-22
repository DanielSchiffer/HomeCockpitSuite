using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSUIPC;

namespace CockpitEnhancerClassic
{
    public class Flightsim
    {
        public Flightsim()
        {
            Debug.Print("Flightsim instanziert");
        }

        public bool Start()
        {
            
            MSFSVariableServices.Start();
            return MSFSVariableServices.IsRunning;
        }

    }
}
