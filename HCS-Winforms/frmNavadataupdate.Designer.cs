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
            panel2 = new Panel();
            pbGesamtFortschritt = new ProgressBar();
            lblWorkItemFortschritt = new Label();
            pbWorkItemFortschritt = new ProgressBar();
            lblGesamtFortschritt = new Label();
            lblBzGesamt = new Label();
            lblWorkitem = new Label();
            label2 = new Label();
            btnAbbrechen = new Button();
            btnOk = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(790, 217);
            tableLayoutPanel1.TabIndex = 0;
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
            panel2.Location = new Point(84, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 147);
            panel2.TabIndex = 1;
            // 
            // pbGesamtFortschritt
            // 
            pbGesamtFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbGesamtFortschritt.Location = new Point(3, 27);
            pbGesamtFortschritt.Name = "pbGesamtFortschritt";
            pbGesamtFortschritt.Size = new Size(529, 18);
            pbGesamtFortschritt.TabIndex = 0;
            // 
            // lblWorkItemFortschritt
            // 
            lblWorkItemFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWorkItemFortschritt.Location = new Point(3, 120);
            lblWorkItemFortschritt.Name = "lblWorkItemFortschritt";
            lblWorkItemFortschritt.Size = new Size(529, 18);
            lblWorkItemFortschritt.TabIndex = 1;
            lblWorkItemFortschritt.Text = "100 %";
            lblWorkItemFortschritt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbWorkItemFortschritt
            // 
            pbWorkItemFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbWorkItemFortschritt.Location = new Point(3, 99);
            pbWorkItemFortschritt.Name = "pbWorkItemFortschritt";
            pbWorkItemFortschritt.Size = new Size(529, 18);
            pbWorkItemFortschritt.TabIndex = 2;
            // 
            // lblGesamtFortschritt
            // 
            lblGesamtFortschritt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGesamtFortschritt.Location = new Point(3, 45);
            lblGesamtFortschritt.Name = "lblGesamtFortschritt";
            lblGesamtFortschritt.Size = new Size(529, 18);
            lblGesamtFortschritt.TabIndex = 3;
            lblGesamtFortschritt.Text = "100 %";
            lblGesamtFortschritt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBzGesamt
            // 
            lblBzGesamt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBzGesamt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBzGesamt.Location = new Point(3, 6);
            lblBzGesamt.Name = "lblBzGesamt";
            lblBzGesamt.Size = new Size(529, 18);
            lblBzGesamt.TabIndex = 4;
            lblBzGesamt.Text = "Gesamt:";
            lblBzGesamt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkitem
            // 
            lblWorkitem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWorkitem.Location = new Point(3, 78);
            lblWorkitem.Name = "lblWorkitem";
            lblWorkitem.Size = new Size(529, 18);
            lblWorkitem.TabIndex = 5;
            lblWorkitem.Text = "Erstelllen des Flughafens EDDB";
            lblWorkitem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(472, 5);
            label2.TabIndex = 6;
            // 
            // btnAbbrechen
            // 
            btnAbbrechen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbbrechen.Location = new Point(83, 0);
            btnAbbrechen.Name = "btnAbbrechen";
            btnAbbrechen.Size = new Size(76, 23);
            btnAbbrechen.TabIndex = 0;
            btnAbbrechen.Text = "abbrechen";
            btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Enabled = false;
            btnOk.Location = new Point(1, 0);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(76, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(btnAbbrechen);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(625, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 26);
            panel1.TabIndex = 0;
            // 
            // frmNavadataupdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 217);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmNavadataupdate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Navigationsdaten";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Button btnOk;
        private Button btnAbbrechen;
    }
}