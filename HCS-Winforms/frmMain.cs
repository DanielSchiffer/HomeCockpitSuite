using Accessibility;
using CockpitEnhancerClassic;
using DanielSchiffer.Contracts.FlugplanungContract;
using DanielSchiffer.HCS.Contracts.CockpitContract;
using System.Windows.Forms;


namespace DanielSchiffer.HCS.UI.HCS_Winforms.Main;

public partial class frmMain : Form
{
    private readonly IFlightSimInterface _FlightSim;
    private System.Windows.Forms.Timer _timer;
    private string test;
    public frmMain(IFlightSimInterface flightSim)
    {
        InitializeComponent();
        this._FlightSim = flightSim;
        _timer = new System.Windows.Forms.Timer();
        test = "Test";
        }  

    private void testfensterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new frmTest(_FlightSim);
        form.Show();

       tbDatum.Text = DateTime.Now.ToString("dd.MM.yy");

    }

    private void Main_Load(object sender, EventArgs e)
    {
        Setze_und_Starte_Timer();
    }
    private void Setze_und_Starte_Timer()
    {
        _timer.Interval = 1000; // Set interval to 1 second;
        _timer.Tick += Timer_Tick; // Add event handler
        _timer.Start(); // Start timer
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        tbDatum.Text = DateTime.Now.ToString("dd.MM.yyyy"); // Display current date in tbDatum
    }
}

