namespace HC6622_Modbus_Simulator
{
    partial class XSIM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XSIM));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.RxStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vca = new System.Windows.Forms.NumericUpDown();
            this.Vbc = new System.Windows.Forms.NumericUpDown();
            this.Vab = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Ic = new System.Windows.Forms.NumericUpDown();
            this.Ib = new System.Windows.Forms.NumericUpDown();
            this.Ia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PF = new System.Windows.Forms.NumericUpDown();
            this.Q = new System.Windows.Forms.NumericUpDown();
            this.P = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Icf = new System.Windows.Forms.NumericUpDown();
            this.Ibf = new System.Windows.Forms.NumericUpDown();
            this.Iaf = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardFault = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.earthFault = new System.Windows.Forms.CheckBox();
            this.phaseFault = new System.Windows.Forms.CheckBox();
            this.reverseFault = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vbc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vab)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ia)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ibf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iaf)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TxStatus,
            this.RxStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(597, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.ImageTransparentColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 19);
            this.toolStripStatusLabel1.Text = "Offline";
            this.toolStripStatusLabel1.ToolTipText = "Com Port Status";
            // 
            // TxStatus
            // 
            this.TxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.TxStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TxStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TxStatus.Margin = new System.Windows.Forms.Padding(490, 3, 0, 2);
            this.TxStatus.Name = "TxStatus";
            this.TxStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxStatus.Size = new System.Drawing.Size(22, 19);
            this.TxStatus.Text = "Tx";
            // 
            // RxStatus
            // 
            this.RxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.RxStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.RxStatus.Name = "RxStatus";
            this.RxStatus.Size = new System.Drawing.Size(23, 19);
            this.RxStatus.Text = "Rx";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(597, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Com Port";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.DropDownClosed += new System.EventHandler(this.toolStripComboBox1_DropDownClosed);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton1.Text = "Connect";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vab";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Vca);
            this.groupBox1.Controls.Add(this.Vbc);
            this.groupBox1.Controls.Add(this.Vab);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voltage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "V";
            // 
            // Vca
            // 
            this.Vca.DecimalPlaces = 2;
            this.Vca.Location = new System.Drawing.Point(53, 92);
            this.Vca.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Vca.Name = "Vca";
            this.Vca.Size = new System.Drawing.Size(107, 20);
            this.Vca.TabIndex = 12;
            this.Vca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Vca.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // Vbc
            // 
            this.Vbc.DecimalPlaces = 2;
            this.Vbc.Location = new System.Drawing.Point(53, 58);
            this.Vbc.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Vbc.Name = "Vbc";
            this.Vbc.Size = new System.Drawing.Size(107, 20);
            this.Vbc.TabIndex = 11;
            this.Vbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Vbc.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // Vab
            // 
            this.Vab.DecimalPlaces = 2;
            this.Vab.Location = new System.Drawing.Point(53, 24);
            this.Vab.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Vab.Name = "Vab";
            this.Vab.Size = new System.Drawing.Size(107, 20);
            this.Vab.TabIndex = 10;
            this.Vab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Vab.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vbc";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Ic);
            this.groupBox2.Controls.Add(this.Ib);
            this.groupBox2.Controls.Add(this.Ia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(225, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 131);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "A";
            // 
            // Ic
            // 
            this.Ic.DecimalPlaces = 2;
            this.Ic.Location = new System.Drawing.Point(53, 92);
            this.Ic.Name = "Ic";
            this.Ic.Size = new System.Drawing.Size(107, 20);
            this.Ic.TabIndex = 12;
            this.Ic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ic.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // Ib
            // 
            this.Ib.DecimalPlaces = 2;
            this.Ib.Location = new System.Drawing.Point(53, 58);
            this.Ib.Name = "Ib";
            this.Ib.Size = new System.Drawing.Size(107, 20);
            this.Ib.TabIndex = 11;
            this.Ib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ib.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // Ia
            // 
            this.Ia.DecimalPlaces = 2;
            this.Ia.Location = new System.Drawing.Point(53, 24);
            this.Ia.Name = "Ia";
            this.Ia.Size = new System.Drawing.Size(107, 20);
            this.Ia.TabIndex = 10;
            this.Ia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ia.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ic";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ib";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.PF);
            this.groupBox3.Controls.Add(this.Q);
            this.groupBox3.Controls.Add(this.P);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 134);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Power";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "MVar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(166, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "MW";
            // 
            // PF
            // 
            this.PF.DecimalPlaces = 2;
            this.PF.Location = new System.Drawing.Point(53, 92);
            this.PF.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.PF.Name = "PF";
            this.PF.Size = new System.Drawing.Size(107, 20);
            this.PF.TabIndex = 12;
            this.PF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PF.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // Q
            // 
            this.Q.DecimalPlaces = 2;
            this.Q.Location = new System.Drawing.Point(53, 58);
            this.Q.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(107, 20);
            this.Q.TabIndex = 11;
            this.Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Q.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // P
            // 
            this.P.DecimalPlaces = 2;
            this.P.Location = new System.Drawing.Point(53, 24);
            this.P.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(107, 20);
            this.P.TabIndex = 10;
            this.P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.P.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "PF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Q";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "P";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.Icf);
            this.groupBox4.Controls.Add(this.Ibf);
            this.groupBox4.Controls.Add(this.Iaf);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(225, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 134);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fault Current";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(166, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(166, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "A";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(166, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "A";
            // 
            // Icf
            // 
            this.Icf.DecimalPlaces = 2;
            this.Icf.Location = new System.Drawing.Point(53, 92);
            this.Icf.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Icf.Name = "Icf";
            this.Icf.Size = new System.Drawing.Size(107, 20);
            this.Icf.TabIndex = 12;
            this.Icf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Icf.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // Ibf
            // 
            this.Ibf.DecimalPlaces = 2;
            this.Ibf.Location = new System.Drawing.Point(53, 58);
            this.Ibf.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Ibf.Name = "Ibf";
            this.Ibf.Size = new System.Drawing.Size(107, 20);
            this.Ibf.TabIndex = 11;
            this.Ibf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ibf.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // Iaf
            // 
            this.Iaf.DecimalPlaces = 2;
            this.Iaf.Location = new System.Drawing.Point(53, 24);
            this.Iaf.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Iaf.Name = "Iaf";
            this.Iaf.Size = new System.Drawing.Size(107, 20);
            this.Iaf.TabIndex = 10;
            this.Iaf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Iaf.ValueChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 94);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Ic";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Ib";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Ia";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // forwardFault
            // 
            this.forwardFault.AutoSize = true;
            this.forwardFault.Location = new System.Drawing.Point(15, 27);
            this.forwardFault.Name = "forwardFault";
            this.forwardFault.Size = new System.Drawing.Size(90, 17);
            this.forwardFault.TabIndex = 9;
            this.forwardFault.Text = "Forward Fault";
            this.forwardFault.UseVisualStyleBackColor = true;
            this.forwardFault.CheckedChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.earthFault);
            this.groupBox5.Controls.Add(this.phaseFault);
            this.groupBox5.Controls.Add(this.reverseFault);
            this.groupBox5.Controls.Add(this.forwardFault);
            this.groupBox5.Location = new System.Drawing.Point(421, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 271);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fault Status";
            // 
            // earthFault
            // 
            this.earthFault.AutoSize = true;
            this.earthFault.Location = new System.Drawing.Point(15, 114);
            this.earthFault.Name = "earthFault";
            this.earthFault.Size = new System.Drawing.Size(77, 17);
            this.earthFault.TabIndex = 12;
            this.earthFault.Text = "Earth Fault";
            this.earthFault.UseVisualStyleBackColor = true;
            this.earthFault.CheckedChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // phaseFault
            // 
            this.phaseFault.AutoSize = true;
            this.phaseFault.Location = new System.Drawing.Point(15, 86);
            this.phaseFault.Name = "phaseFault";
            this.phaseFault.Size = new System.Drawing.Size(82, 17);
            this.phaseFault.TabIndex = 11;
            this.phaseFault.Text = "Phase Fault";
            this.phaseFault.UseVisualStyleBackColor = true;
            this.phaseFault.CheckedChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // reverseFault
            // 
            this.reverseFault.AutoSize = true;
            this.reverseFault.Location = new System.Drawing.Point(15, 56);
            this.reverseFault.Name = "reverseFault";
            this.reverseFault.Size = new System.Drawing.Size(92, 17);
            this.reverseFault.TabIndex = 10;
            this.reverseFault.Text = "Reverse Fault";
            this.reverseFault.UseVisualStyleBackColor = true;
            this.reverseFault.CheckedChanged += new System.EventHandler(this.ValueUpdate);
            // 
            // XSIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 371);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "XSIM";
            this.Text = "DPT X-SIMULATOR";
            this.Load += new System.EventHandler(this.XSIM_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vbc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vab)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ibf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iaf)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Vab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Vca;
        private System.Windows.Forms.NumericUpDown Vbc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Ic;
        private System.Windows.Forms.NumericUpDown Ib;
        private System.Windows.Forms.NumericUpDown Ia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown PF;
        private System.Windows.Forms.NumericUpDown Q;
        private System.Windows.Forms.NumericUpDown P;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown Icf;
        private System.Windows.Forms.NumericUpDown Ibf;
        private System.Windows.Forms.NumericUpDown Iaf;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel TxStatus;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel RxStatus;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox forwardFault;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox earthFault;
        private System.Windows.Forms.CheckBox phaseFault;
        private System.Windows.Forms.CheckBox reverseFault;
    }
}

