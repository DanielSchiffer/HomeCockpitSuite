using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSUIPC;
using DanielSchiffer.HCS.Contracts.CockpitContract;



namespace CockpitEnhancerClassic
{
    public class Flightsim :IFlightSimInterface
    {
        public Flightsim()
        {
            Debug.Print("Flightsim instanziert");
            MSFSVariableServices.Init();
        }

        public bool Start()
        {
            MSFSVariableServices.Start();
            return MSFSVariableServices.IsRunning;
        }

    }
}
