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

        public frmTest(IFlightSimInterface flightSim)
        {
            InitializeComponent();
            this.flightSim = flightSim;
        }

        private void btnAusführen_Click(object sender, EventArgs e)
        {
           
            if (flightSim.Start())
            {
                tbAusgabe.Text = "Gestartet!";
            }
            else
            {
                tbAusgabe.Text = "nicht gestartet!";
            }
        }
    }
}
