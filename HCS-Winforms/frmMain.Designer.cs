namespace DanielSchiffer.HCS.UI.HCS_Winforms.Main
{
    partial class FrmMain
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
            flightToolStripMenuItem = new ToolStripMenuItem();
            simbriefToolStripMenuItem = new ToolStripMenuItem();
            navDataToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            btnDestSugestion = new Button();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            gbStammdaten = new GroupBox();
            textBox1 = new TextBox();
            gbHeute = new GroupBox();
            tbUTC = new TextBox();
            tbLocalTime = new TextBox();
            tbDatum = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label5 = new Label();
            cbFlightNumberLock = new CheckBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            StatusBar = new StatusStrip();
            imageList1 = new ImageList(components);
            updateFromFileToolStripMenuItem = new ToolStripMenuItem();
            MainMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            gbStammdaten.SuspendLayout();
            gbHeute.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.ImageScalingSize = new Size(24, 24);
            MainMenu.Items.AddRange(new ToolStripItem[] { testfensterToolStripMenuItem, flightToolStripMenuItem, simbriefToolStripMenuItem, navDataToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(12, 4, 0, 4);
            MainMenu.Size = new Size(1006, 27);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "menuStrip1";
            // 
            // testfensterToolStripMenuItem
            // 
            testfensterToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            testfensterToolStripMenuItem.Name = "testfensterToolStripMenuItem";
            testfensterToolStripMenuItem.Size = new Size(75, 19);
            testfensterToolStripMenuItem.Text = "Testfenster";
            // 
            // flightToolStripMenuItem
            // 
            flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            flightToolStripMenuItem.Size = new Size(49, 19);
            flightToolStripMenuItem.Text = "Flight";
            // 
            // simbriefToolStripMenuItem
            // 
            simbriefToolStripMenuItem.Name = "simbriefToolStripMenuItem";
            simbriefToolStripMenuItem.Size = new Size(63, 19);
            simbriefToolStripMenuItem.Text = "Simbrief";
            // 
            // navDataToolStripMenuItem
            // 
            navDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateFromFileToolStripMenuItem });
            navDataToolStripMenuItem.Name = "navDataToolStripMenuItem";
            navDataToolStripMenuItem.Size = new Size(69, 19);
            navDataToolStripMenuItem.Text = "Nav-Data";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(gbStammdaten, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 27);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.2118378F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2087231F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.57944F));
            tableLayoutPanel1.Size = new Size(1006, 642);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnDestSugestion);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(3, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 89);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Route";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 21);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 7;
            label9.Text = "Destination";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 21);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 7;
            label8.Text = "Depature";
            // 
            // btnDestSugestion
            // 
            btnDestSugestion.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDestSugestion.Location = new Point(231, 33);
            btnDestSugestion.Name = "btnDestSugestion";
            btnDestSugestion.Size = new Size(75, 46);
            btnDestSugestion.TabIndex = 5;
            btnDestSugestion.Text = "Destination\r\nSuggestion";
            btnDestSugestion.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(132, 45);
            maskedTextBox2.Mask = "LLLL";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(89, 29);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(9, 45);
            maskedTextBox1.Mask = "LLLL";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(89, 29);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 48);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 2;
            label4.Text = "-->";
            // 
            // gbStammdaten
            // 
            gbStammdaten.Controls.Add(textBox1);
            gbStammdaten.Controls.Add(gbHeute);
            gbStammdaten.Controls.Add(label7);
            gbStammdaten.Controls.Add(label5);
            gbStammdaten.Controls.Add(cbFlightNumberLock);
            gbStammdaten.Controls.Add(comboBox1);
            gbStammdaten.Controls.Add(label6);
            gbStammdaten.Dock = DockStyle.Fill;
            gbStammdaten.Location = new Point(4, 4);
            gbStammdaten.Margin = new Padding(4);
            gbStammdaten.Name = "gbStammdaten";
            gbStammdaten.Padding = new Padding(4);
            gbStammdaten.Size = new Size(327, 263);
            gbStammdaten.TabIndex = 0;
            gbStammdaten.TabStop = false;
            gbStammdaten.Text = "Stammdaten";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(107, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 29);
            textBox1.TabIndex = 11;
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
            gbHeute.Size = new Size(277, 90);
            gbHeute.TabIndex = 0;
            gbHeute.TabStop = false;
            gbHeute.Text = "Today";
            // 
            // tbUTC
            // 
            tbUTC.Location = new Point(186, 51);
            tbUTC.Margin = new Padding(4);
            tbUTC.Name = "tbUTC";
            tbUTC.ReadOnly = true;
            tbUTC.Size = new Size(78, 29);
            tbUTC.TabIndex = 5;
            tbUTC.Text = "14:04";
            tbUTC.TextAlign = HorizontalAlignment.Center;
            // 
            // tbLocalTime
            // 
            tbLocalTime.Location = new Point(102, 51);
            tbLocalTime.Margin = new Padding(4);
            tbLocalTime.Name = "tbLocalTime";
            tbLocalTime.ReadOnly = true;
            tbLocalTime.Size = new Size(76, 29);
            tbLocalTime.TabIndex = 4;
            tbLocalTime.Text = "15:04";
            tbLocalTime.TextAlign = HorizontalAlignment.Center;
            // 
            // tbDatum
            // 
            tbDatum.Location = new Point(8, 51);
            tbDatum.Margin = new Padding(4);
            tbDatum.Name = "tbDatum";
            tbDatum.ReadOnly = true;
            tbDatum.Size = new Size(86, 29);
            tbDatum.TabIndex = 3;
            tbDatum.Text = "22.03.24";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 2;
            label3.Text = "UTC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "Local";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Datum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(226, 140);
            label7.Name = "label7";
            label7.Size = new Size(30, 13);
            label7.TabIndex = 10;
            label7.Text = "Lock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 132);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 6;
            label5.Text = "Airline";
            // 
            // cbFlightNumberLock
            // 
            cbFlightNumberLock.AutoSize = true;
            cbFlightNumberLock.Location = new Point(234, 156);
            cbFlightNumberLock.Name = "cbFlightNumberLock";
            cbFlightNumberLock.Size = new Size(15, 14);
            cbFlightNumberLock.TabIndex = 9;
            cbFlightNumberLock.TextAlign = ContentAlignment.MiddleCenter;
            cbFlightNumberLock.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(67, 29);
            comboBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 132);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 8;
            label6.Text = "Flight-Number";
            // 
            // StatusBar
            // 
            StatusBar.ImageScalingSize = new Size(24, 24);
            StatusBar.Location = new Point(0, 647);
            StatusBar.Name = "StatusBar";
            StatusBar.Padding = new Padding(1, 0, 26, 0);
            StatusBar.Size = new Size(1006, 22);
            StatusBar.TabIndex = 2;
            StatusBar.Text = "statusStrip1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // updateFromFileToolStripMenuItem
            // 
            updateFromFileToolStripMenuItem.Name = "updateFromFileToolStripMenuItem";
            updateFromFileToolStripMenuItem.Size = new Size(180, 22);
            updateFromFileToolStripMenuItem.Text = "Update from File";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 669);
            Controls.Add(StatusBar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MainMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = MainMenu;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "Form1";
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbStammdaten.ResumeLayout(false);
            gbStammdaten.PerformLayout();
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
        private ToolStripMenuItem flightToolStripMenuItem;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private Button btnDestSugestion;
        private ToolStripMenuItem simbriefToolStripMenuItem;
        private ToolStripMenuItem navDataToolStripMenuItem;
        private Label label5;
        private TextBox textBox1;
        private Label label7;
        private CheckBox cbFlightNumberLock;
        private Label label6;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private ToolStripMenuItem updateFromFileToolStripMenuItem;
    }
}
