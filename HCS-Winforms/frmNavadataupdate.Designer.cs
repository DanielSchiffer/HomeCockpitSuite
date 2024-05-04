namespace DanielSchiffer.HCS.UI.HCS_Winforms
{
    partial class frmNavadataupdate
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnErstellen = new Button();
            btnAbbrechen = new Button();
            panel2 = new Panel();
            label2 = new Label();
            lblWorkitem = new Label();
            lblBzGesamt = new Label();
            lblGesamtFortschritt = new Label();
            pbWorkItemFortschritt = new ProgressBar();
            lblWorkItemFortschritt = new Label();
            pbGesamtFortschritt = new ProgressBar();
            gbDaten = new GroupBox();
            lblGültigBis = new Label();
            lblGültigVon = new Label();
            label4 = new Label();
            label3 = new Label();
            lblAirac = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            gbDaten.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.35605F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.64395F));
            tableLayoutPanel1.Controls.Add(panel1, 2, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(gbDaten, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(854, 258);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnErstellen);
            panel1.Controls.Add(btnAbbrechen);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(674, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 47);
            panel1.TabIndex = 0;
            // 
            // btnErstellen
            // 
            btnErstellen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnErstellen.Enabled = false;
            btnErstellen.Location = new Point(16, 21);
            btnErstellen.Name = "btnErstellen";
            btnErstellen.Size = new Size(76, 23);
            btnErstellen.TabIndex = 1;
            btnErstellen.Text = "erstellen";
            btnErstellen.UseVisualStyleBackColor = true;
            // 
            // btnAbbrechen
            // 
            btnAbbrechen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbbrechen.Location = new Point(98, 21);
            btnAbbrechen.Name = "btnAbbrechen";
            btnAbbrechen.Size = new Size(76, 23);
            btnAbbrechen.TabIndex = 0;
            btnAbbrechen.Text = "abbrechen";
            btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblWorkitem);
            panel2.Controls.Add(lblBzGesamt);
            panel2.Controls.Add(lblGesamtFortschritt);
            panel2.Controls.Add(pbWorkItemFortschritt);
            panel2.Controls.Add(lblWorkItemFortschritt);
            panel2.Controls.Add(pbGesamtFortschritt);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(84, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 147);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(521, 5);
            label2.TabIndex = 6;
            // 
            // lblWorkitem
            // 
            lblWorkitem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWorkitem.Location = new Point(3, 78);
            lblWorkitem.Name = "lblWorkitem";
            lblWorkitem.Size = new Size(578, 18);
            lblWorkitem.TabIndex = 5;
            lblWorkitem.Text = "Erstelllen des Flughafens EDDB";
            lblWorkitem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBzGesamt
            // 
            lblBzGesamt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBzGesamt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBzGesamt.Location = new Point(3, 6);
            lblBzGesamt.Name = "lblBzGesamt";
            lblBzGesamt.Size = new Size(578, 18);
            lblBzGesamt.TabIndex = 4;
            lblBzGesamt.Text = "Gesamt:";
            lblBzGesamt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGesamtFortschritt
            // 
            lblGesamtFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGesamtFortschritt.Location = new Point(3, 45);
            lblGesamtFortschritt.Name = "lblGesamtFortschritt";
            lblGesamtFortschritt.Size = new Size(578, 18);
            lblGesamtFortschritt.TabIndex = 3;
            lblGesamtFortschritt.Text = "100 %";
            lblGesamtFortschritt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbWorkItemFortschritt
            // 
            pbWorkItemFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbWorkItemFortschritt.Location = new Point(3, 99);
            pbWorkItemFortschritt.Name = "pbWorkItemFortschritt";
            pbWorkItemFortschritt.Size = new Size(578, 18);
            pbWorkItemFortschritt.TabIndex = 2;
            // 
            // lblWorkItemFortschritt
            // 
            lblWorkItemFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWorkItemFortschritt.Location = new Point(3, 120);
            lblWorkItemFortschritt.Name = "lblWorkItemFortschritt";
            lblWorkItemFortschritt.Size = new Size(578, 18);
            lblWorkItemFortschritt.TabIndex = 1;
            lblWorkItemFortschritt.Text = "100 %";
            lblWorkItemFortschritt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbGesamtFortschritt
            // 
            pbGesamtFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbGesamtFortschritt.Location = new Point(3, 27);
            pbGesamtFortschritt.Name = "pbGesamtFortschritt";
            pbGesamtFortschritt.Size = new Size(578, 18);
            pbGesamtFortschritt.TabIndex = 0;
            // 
            // gbDaten
            // 
            gbDaten.Controls.Add(lblGültigBis);
            gbDaten.Controls.Add(lblGültigVon);
            gbDaten.Controls.Add(label4);
            gbDaten.Controls.Add(label3);
            gbDaten.Controls.Add(lblAirac);
            gbDaten.Controls.Add(label1);
            gbDaten.Dock = DockStyle.Fill;
            gbDaten.Location = new Point(674, 55);
            gbDaten.Name = "gbDaten";
            gbDaten.Size = new Size(177, 147);
            gbDaten.TabIndex = 2;
            gbDaten.TabStop = false;
            gbDaten.Text = "Navdaten";
            // 
            // lblGültigBis
            // 
            lblGültigBis.AutoSize = true;
            lblGültigBis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGültigBis.Location = new Point(6, 117);
            lblGültigBis.Name = "lblGültigBis";
            lblGültigBis.Size = new Size(52, 21);
            lblGültigBis.TabIndex = 5;
            lblGültigBis.Text = "22-14";
            // 
            // lblGültigVon
            // 
            lblGültigVon.AutoSize = true;
            lblGültigVon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGültigVon.Location = new Point(6, 75);
            lblGültigVon.Name = "lblGültigVon";
            lblGültigVon.Size = new Size(52, 21);
            lblGültigVon.TabIndex = 4;
            lblGültigVon.Text = "22-14";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 96);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "gültig bis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "gültig von:";
            // 
            // lblAirac
            // 
            lblAirac.AutoSize = true;
            lblAirac.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAirac.Location = new Point(6, 34);
            lblAirac.Name = "lblAirac";
            lblAirac.Size = new Size(52, 21);
            lblAirac.TabIndex = 1;
            lblAirac.Text = "22-14";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Airac im Importordner:";
            // 
            // frmNavadataupdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 258);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmNavadataupdate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Navigationsdaten";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gbDaten.ResumeLayout(false);
            gbDaten.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label lblWorkitem;
        private Label lblBzGesamt;
        private Label lblGesamtFortschritt;
        private ProgressBar pbWorkItemFortschritt;
        private Label lblWorkItemFortschritt;
        private ProgressBar pbGesamtFortschritt;
        private Label label2;
        private Panel panel1;
        private Button btnErstellen;
        private Button btnAbbrechen;
        private GroupBox gbDaten;
        private Label lblGültigBis;
        private Label lblGültigVon;
        private Label label4;
        private Label label3;
        private Label lblAirac;
        private Label label1;
    }
}