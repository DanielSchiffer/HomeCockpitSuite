using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSUIPC;
using Sim = FSUIPC.MSFSVariableServices;
using DanielSchiffer.HCS.Contracts.CockpitContract;



namespace CockpitEnhancerClassic
{
    public class Flightsim : IFlightSimInterface
    {
        public event EventHandler<string> LogEntryReceived;
        public event EventHandler VariableListChanged;
        public event EventHandler ValuesChanged;

        public Flightsim()
        {
            Debug.Print("Flightsim instanziert");
            Sim.Init();
            Sim.OnLogEntryReceived += VS_OnLogEntryReceived; // Fired when the WASM module sends a log entry
            Sim.OnVariableListChanged += VS_VariableListChanged; // Fired when the list of available variables is changed
            Sim.OnValuesChanged += VS_OnValuesChanged; // Fired when any LVAR value changes
        }

        /// <summary>
        /// Fired when any LVAR value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void VS_OnValuesChanged(object sender, EventArgs e)
        {
            ValuesChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Fired when the list of available variables is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void VS_VariableListChanged(object sender, EventArgs e)
        {
            
            VariableListChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Fired when the WASM module sends a log entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void VS_OnLogEntryReceived(object sender, LogEventArgs e)
        {
            LogEntryReceived?.Invoke(sender, e.LogEntry);
        }

        public bool Start()
        {
            Sim.Start();
            return Sim.IsRunning;
        }
    }
}
