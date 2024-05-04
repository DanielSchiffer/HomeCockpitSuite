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
            btnAbbrechen.Click += (s, e) => Close();
            btnErstellen.Click += (s, e) => vm.Erstellen();
            pbGesamtFortschritt.DataBindings.Add(nameof(pbGesamtFortschritt.Value), vm, nameof(vm.GesamtFortschritt), false, DataSourceUpdateMode.OnPropertyChanged);
            lblGesamtFortschritt.DataBindings.Add(nameof(lblGesamtFortschritt.Text), vm, nameof(vm.GesamtFortschritt), false, DataSourceUpdateMode.OnPropertyChanged,"-");
            lblGesamtFortschritt.DataBindings[0].Format += (s, e) => e.Value = $"{e.Value} %";
            pbWorkItemFortschritt.DataBindings.Add(nameof(pbWorkItemFortschritt.Value), vm, nameof(vm.WorkItemFortschritt), false, DataSourceUpdateMode.OnPropertyChanged);
            lblWorkItemFortschritt.DataBindings.Add(nameof(lblWorkItemFortschritt.Text), vm, nameof(vm.WorkItemFortschritt), false, DataSourceUpdateMode.OnPropertyChanged, "-");
            lblWorkItemFortschritt.DataBindings[0].Format += (s, e) => e.Value = $"{e.Value} %";
            lblWorkitem.DataBindings.Add(nameof(lblWorkitem.Text), vm, nameof(vm.WorkItemText), false, DataSourceUpdateMode.OnPropertyChanged);
            lblAirac.DataBindings.Add(nameof(lblAirac.Text), vm, nameof(vm.Airac), false, DataSourceUpdateMode.OnPropertyChanged);
            lblGültigVon.DataBindings.Add(nameof(lblGültigVon.Text), vm, nameof(vm.GueltigVon), false, DataSourceUpdateMode.OnPropertyChanged);
            lblGültigBis.DataBindings.Add(nameof(lblGültigBis.Text), vm, nameof(vm.GueltigBis), false, DataSourceUpdateMode.OnPropertyChanged);
            btnErstellen.DataBindings.Add(nameof(btnErstellen.Enabled),vm, nameof(vm.NavdataErstellbar), false, DataSourceUpdateMode.OnPropertyChanged);

        }

    }
}
