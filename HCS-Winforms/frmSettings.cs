﻿using DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels;
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
    public partial class frmSettings : Form
    {
        private readonly SettingsModel vm;

        public frmSettings(SettingsModel vm)
        {
            InitializeComponent();
            this.vm = vm;

            tbSimBriefUser.DataBindings.Add(nameof(tbSimBriefUser.Text), vm, nameof(vm.SimBriefUser), false, DataSourceUpdateMode.OnPropertyChanged);
            cbEntwicklerModus.DataBindings.Add(nameof(cbEntwicklerModus.Checked), vm, nameof(vm.EntwicklerModus), false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
