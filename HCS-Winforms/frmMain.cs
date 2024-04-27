using Accessibility;
using CockpitEnhancerClassic;
using DanielSchiffer.Contracts.FlugplanungContract;
using DanielSchiffer.HCS.Contracts.CockpitContract;
using DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels;
using System.Windows.Forms;


namespace DanielSchiffer.HCS.UI.HCS_Winforms.Main;

public partial class FrmMain : Form
{


    public FrmMain(MainModel vm)
    {
        InitializeComponent();

        tbDatum.DataBindings.Add(nameof(tbDatum.Text), vm, nameof(vm.Datum), false, DataSourceUpdateMode.OnPropertyChanged);
        tbLocalTime.DataBindings.Add(nameof(tbLocalTime.Text), vm, nameof(vm.Uhrzeit), false, DataSourceUpdateMode.OnPropertyChanged);
        tbUTC.DataBindings.Add(nameof(tbUTC.Text), vm, nameof(vm.Utc), false, DataSourceUpdateMode.OnPropertyChanged);

        //Events
        FormClosing += (s, e) => vm.OnClosing();

        //Menu
        testfensterToolStripMenuItem.Click += (s, e) => vm.OnTestWindow();
        updateFromFileToolStripMenuItem.Click += (s, e) => vm.NavdataUpdateFromFile();
        
    }

    
}

