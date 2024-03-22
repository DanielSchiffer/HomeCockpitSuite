namespace DanielSchiffer.HCS.UI.HCS_Winforms
{
    partial class frmTest
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
            tbAusgabe = new TextBox();
            btnAusführen = new Button();
            SuspendLayout();
            // 
            // tbAusgabe
            // 
            tbAusgabe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAusgabe.Location = new Point(12, 81);
            tbAusgabe.Multiline = true;
            tbAusgabe.Name = "tbAusgabe";
            tbAusgabe.Size = new Size(722, 372);
            tbAusgabe.TabIndex = 0;
            // 
            // btnAusführen
            // 
            btnAusführen.Location = new Point(12, 12);
            btnAusführen.Name = "btnAusführen";
            btnAusführen.Size = new Size(165, 63);
            btnAusführen.TabIndex = 1;
            btnAusführen.Text = "ausführen";
            btnAusführen.UseVisualStyleBackColor = true;
            btnAusführen.Click += btnAusführen_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 465);
            Controls.Add(btnAusführen);
            Controls.Add(tbAusgabe);
            Name = "frmTest";
            Text = "frmTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAusgabe;
        private Button btnAusführen;
    }
}