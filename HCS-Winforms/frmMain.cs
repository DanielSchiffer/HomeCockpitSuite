using Accessibility;
using CockpitEnhancerClassic;
using DanielSchiffer.Contracts.FlugplanungContract;
using DanielSchiffer.HCS.Contracts.CockpitContract;
using DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels;
using System.Windows.Forms;


namespace DanielSchiffer.HCS.UI.HCS_Winforms.Main;

public partial class frmMain : Form
{

    private readonly Model_frmMain vm;

    public frmMain(Model_frmMain vm)
    { 
        InitializeComponent();
        this.vm = vm;
        tbDatum.DataBindings.Add(nameof(tbDatum.Text), vm, "Datum", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    

    
}

