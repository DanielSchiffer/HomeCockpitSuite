using DanielSchiffer.Contracts.FlugplanungContract;
using DanielSchiffer.HCS.Contracts.CockpitContract;

namespace DanielSchiffer.HCS.UI.HCS_Winforms;

public partial class Main : Form
{
    private readonly IFlightSimInterface _FlightSim;

    public Main(IFlightSimInterface flightSim)
    {
        InitializeComponent();
        this._FlightSim = flightSim;
    }

    private void testfensterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new frmTest(_FlightSim);
        form.Show();    
    }
}
