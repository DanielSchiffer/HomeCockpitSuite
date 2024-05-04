namespace DanielSchiffer.HCS.UI.HCS_Winforms
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbSimBriefUser = new TextBox();
            label1 = new Label();
            bgAllgemein = new GroupBox();
            cbEntwicklerModus = new CheckBox();
            groupBox1.SuspendLayout();
            bgAllgemein.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSimBriefUser);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SimBrief";
            // 
            // tbSimBriefUser
            // 
            tbSimBriefUser.Location = new Point(6, 37);
            tbSimBriefUser.Name = "tbSimBriefUser";
            tbSimBriefUser.Size = new Size(134, 23);
            tbSimBriefUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // bgAllgemein
            // 
            bgAllgemein.Controls.Add(cbEntwicklerModus);
            bgAllgemein.Location = new Point(12, 12);
            bgAllgemein.Name = "bgAllgemein";
            bgAllgemein.Size = new Size(198, 100);
            bgAllgemein.TabIndex = 1;
            bgAllgemein.TabStop = false;
            bgAllgemein.Text = "Allgemein";
            // 
            // cbEntwicklerModus
            // 
            cbEntwicklerModus.AutoSize = true;
            cbEntwicklerModus.Location = new Point(6, 22);
            cbEntwicklerModus.Name = "cbEntwicklerModus";
            cbEntwicklerModus.Size = new Size(122, 19);
            cbEntwicklerModus.TabIndex = 0;
            cbEntwicklerModus.Text = "Entwickler-Modus";
            cbEntwicklerModus.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bgAllgemein);
            Controls.Add(groupBox1);
            Name = "frmSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSettings";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            bgAllgemein.ResumeLayout(false);
            bgAllgemein.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbSimBriefUser;
        private Label label1;
        private GroupBox bgAllgemein;
        private CheckBox cbEntwicklerModus;
    }
}