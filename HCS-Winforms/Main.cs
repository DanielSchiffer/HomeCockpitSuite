using DanielSchiffer.Contracts.FlugplanungContract;

namespace DanielSchiffer.HCS.UI.HCS_Winforms;

public partial class Main : Form
{
    private readonly IPlanung planung;

    public Main(IPlanung planung)
    {
        InitializeComponent();
        this.planung = planung;
    }

    private void testfensterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new frmTest();
        form.Show();    
    }
}
