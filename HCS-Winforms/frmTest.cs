using DanielSchiffer.HCS.Contracts.CockpitContract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielSchiffer.HCS.UI.HCS_Winforms
{
    public partial class frmTest : Form
    {
        private readonly IFlightSimInterface flightSim;
        private bool _flightSimReady;

        public frmTest(IFlightSimInterface flightSim)
        {
            InitializeComponent();
            this.flightSim = flightSim;
            flightSim.LogEntryReceived += FlightSim_LogEntryReceived;
        }

        private void FlightSim_LogEntryReceived(object? sender, string e)
        {
            lbAusgabe.Items.Add(e);
        }

        private void btnAusführen_Click(object sender, EventArgs e)
        {

            _flightSimReady = flightSim.Start();
        }


    }
}
