namespace DanielSchiffer.HCS.UI.HCS_Winforms.Main
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MainMenu = new MenuStrip();
            testfensterToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbStammdaten = new GroupBox();
            gbHeute = new GroupBox();
            tbUTC = new TextBox();
            tbLocalTime = new TextBox();
            tbDatum = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            StatusBar = new StatusStrip();
            imageList1 = new ImageList(components);
            MainMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbStammdaten.SuspendLayout();
            gbHeute.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.ImageScalingSize = new Size(24, 24);
            MainMenu.Items.AddRange(new ToolStripItem[] { testfensterToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(12, 4, 0, 4);
            MainMenu.Size = new Size(2241, 37);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "menuStrip1";
            // 
            // testfensterToolStripMenuItem
            // 
            testfensterToolStripMenuItem.Name = "testfensterToolStripMenuItem";
            testfensterToolStripMenuItem.Size = new Size(112, 29);
            testfensterToolStripMenuItem.Text = "Testfenster";
            testfensterToolStripMenuItem.Click += testfensterToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(gbStammdaten, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 37);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(2241, 1266);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // gbStammdaten
            // 
            gbStammdaten.Controls.Add(gbHeute);
            gbStammdaten.Dock = DockStyle.Fill;
            gbStammdaten.Location = new Point(4, 4);
            gbStammdaten.Margin = new Padding(4);
            gbStammdaten.Name = "gbStammdaten";
            gbStammdaten.Padding = new Padding(4);
            gbStammdaten.Size = new Size(739, 414);
            gbStammdaten.TabIndex = 0;
            gbStammdaten.TabStop = false;
            gbStammdaten.Text = "Stammdaten";
            // 
            // gbHeute
            // 
            gbHeute.Controls.Add(tbUTC);
            gbHeute.Controls.Add(tbLocalTime);
            gbHeute.Controls.Add(tbDatum);
            gbHeute.Controls.Add(label3);
            gbHeute.Controls.Add(label2);
            gbHeute.Controls.Add(label1);
            gbHeute.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbHeute.Location = new Point(12, 38);
            gbHeute.Margin = new Padding(4);
            gbHeute.Name = "gbHeute";
            gbHeute.Padding = new Padding(4);
            gbHeute.Size = new Size(374, 138);
            gbHeute.TabIndex = 0;
            gbHeute.TabStop = false;
            gbHeute.Text = "Heute";
            // 
            // tbUTC
            // 
            tbUTC.Location = new Point(251, 70);
            tbUTC.Margin = new Padding(4);
            tbUTC.Name = "tbUTC";
            tbUTC.ReadOnly = true;
            tbUTC.Size = new Size(115, 39);
            tbUTC.TabIndex = 5;
            tbUTC.Text = "14:04";
            // 
            // tbLocalTime
            // 
            tbLocalTime.Location = new Point(137, 71);
            tbLocalTime.Margin = new Padding(4);
            tbLocalTime.Name = "tbLocalTime";
            tbLocalTime.ReadOnly = true;
            tbLocalTime.Size = new Size(106, 39);
            tbLocalTime.TabIndex = 4;
            tbLocalTime.Text = "15:04";
            // 
            // tbDatum
            // 
            tbDatum.Location = new Point(8, 70);
            tbDatum.Margin = new Padding(4);
            tbDatum.Name = "tbDatum";
            tbDatum.ReadOnly = true;
            tbDatum.Size = new Size(121, 39);
            tbDatum.TabIndex = 3;
            tbDatum.Text = "22.03.2024";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 2;
            label3.Text = "UTC-Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 1;
            label2.Text = "Localtime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "Datum";
            // 
            // StatusBar
            // 
            StatusBar.ImageScalingSize = new Size(24, 24);
            StatusBar.Location = new Point(0, 1281);
            StatusBar.Name = "StatusBar";
            StatusBar.Padding = new Padding(1, 0, 26, 0);
            StatusBar.Size = new Size(2241, 22);
            StatusBar.TabIndex = 2;
            StatusBar.Text = "statusStrip1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2241, 1303);
            Controls.Add(StatusBar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MainMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = MainMenu;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            gbStammdaten.ResumeLayout(false);
            gbHeute.ResumeLayout(false);
            gbHeute.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem testfensterToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private StatusStrip StatusBar;
        private GroupBox gbStammdaten;
        private GroupBox gbHeute;
        private TextBox tbUTC;
        private TextBox tbLocalTime;
        private TextBox tbDatum;
        private Label label3;
        private Label label2;
        private Label label1;
        private ImageList imageList1;
    }
}
