using DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels;
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
    public partial class frmNavadataupdate : Form
    {
        public frmNavadataupdate(NavdataUpdateModel vm)
        {
            InitializeComponent();
            this.Load += (s, e) => vm.OnLoad();

        }
    }
}
