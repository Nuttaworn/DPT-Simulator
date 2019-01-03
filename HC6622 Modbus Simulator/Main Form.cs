using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Collections;

namespace HC6622_Modbus_Simulator
{
    public partial class XSIM : Form
    {
        const int serialDataReceivedIntervel = 100;    // timer off delay for receiving data from serialport
        const int rtuAddress = 1;
        // Serial Communication
        private Queue rawdataBuffer = new Queue(50);
        private List<byte> inputBuffer = new List<byte>();
        public modbusRTU rtu = new modbusRTU();
        
        public XSIM()
        {
            InitializeComponent();
            this.rtu.address = rtuAddress;
            //mess
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                toolStripComboBox1.Items.Add(s);
            }
        }

        private void toolStripComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Items.Count > 0)
            {
                try
                {
                    this.serialPort1.PortName = toolStripComboBox1.SelectedItem.ToString();
                    toolStripButton1.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Please select any port.");
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Close();
                this.toolStripButton1.Text = "Connect";
                this.toolStripStatusLabel1.Text = "Offline";
                this.toolStripStatusLabel1.BackColor = Color.Red;
                this.toolStripComboBox1.Enabled = true;
            }
            else
            {
                try
                {
                    this.serialPort1.Open();
                    this.toolStripComboBox1.Enabled = false;
                    this.toolStripButton1.Text = "Disconnect";
                    this.toolStripStatusLabel1.Text = "Online";
                    this.toolStripStatusLabel1.BackColor = Color.FromArgb(0, 255, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Obtain the number of bytes waiting in the port's buffer
            this.Invoke(new EventHandler(delegate
            {
                this.RxStatus.BackColor = Color.Lime;
            }));

            int bytes = serialPort1.BytesToRead;

            if (bytes <= 0)
            {
                return;
            }
            byte[] rawdata;
            rawdata = new byte[bytes];

            serialPort1.Read(rawdata, 0, bytes);
            // put data into the q and wait for scanning
            for (int i = 0; i < bytes; i++)
            {
                this.inputBuffer.Add(rawdata[i]);
            }

            this.Invoke(new EventHandler(delegate
            {
                this.timer1.Enabled = true;
                this.timer1.Interval = serialDataReceivedIntervel;
            }));
        }

        [STAThread]
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.RxStatus.BackColor = this.TxStatus.BackColor;
            if (this.inputBuffer.Count > 2)
            {
                byte[] userdata = (byte[])this.inputBuffer.ToArray();
                

                //--------------------------- MODBUS DECODING START HERE --------------------------//
                //String s = " : ";
                //for (int i = 0; i < userdata.Length; i++)
                //{
                //    s += " " + userdata[i].ToString();
                //}
                //MessageBox.Show(s);
                try
                {
                    if (modbusCRC.chkCRC(userdata))
                    {
                        bool a = this.rtu.Response(userdata, ref this.serialPort1);
                        if (a)
                        {
                            this.TxStatus.BackColor = Color.Red;
                            this.timer2.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                  
            }
            this.inputBuffer.Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer2.Interval = serialDataReceivedIntervel;
            this.TxStatus.BackColor = Control.DefaultBackColor;
        }

        private void XSIM_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            this.toolStripStatusLabel1.Text = "Offline";
            this.toolStripStatusLabel1.BackColor = Color.Red;
            foreach (string s in SerialPort.GetPortNames())
            {
                toolStripComboBox1.Items.Add(s);
            }
            if (toolStripComboBox1.Items.Count > 0)
            {
                this.toolStripComboBox1.SelectedIndex = 0;
                this.serialPort1.PortName = toolStripComboBox1.SelectedItem.ToString();
            }
            else toolStripButton1.Enabled = false;
        }

        private void ValueUpdate(object sender, EventArgs e)
        {
            this.rtu.regAnalog[0] = (Int16)(this.Ia.Value * 2500);
            this.rtu.regAnalog[1] = (Int16)(this.Ib.Value * 2500);
            this.rtu.regAnalog[2] = (Int16)(this.Ic.Value * 2500);

            this.rtu.regAnalog[4] = (Int16)(this.Vab.Value * 100);
            this.rtu.regAnalog[5] = (Int16)(this.Vbc.Value * 100);
            this.rtu.regAnalog[6] = (Int16)(this.Vca.Value * 100);

            this.rtu.regAnalog[7] = (Int16)((double)this.P.Value * 208.33);
            this.rtu.regAnalog[8] = (Int16)((double)this.Q.Value * 208.33);
            this.rtu.regAnalog[9] = (Int16)(this.PF.Value * 100);

            this.rtu.regAnalog[10] = (Int16)(this.Iaf.Value * 2500);
            this.rtu.regAnalog[11] = (Int16)(this.Ibf.Value * 2500);
            this.rtu.regAnalog[12] = (Int16)(this.Icf.Value * 2500);

            if (this.forwardFault.Checked) this.rtu.regFault[0] = 1;
            else this.rtu.regFault[0] = 0;

            if (this.reverseFault.Checked) this.rtu.regFault[1] = 1;
            else this.rtu.regFault[1] = 0;

            if (this.phaseFault.Checked) this.rtu.regFault[2] = 1;
            else this.rtu.regFault[2] = 0;

            if (this.earthFault.Checked) this.rtu.regFault[3] = 1;
            else this.rtu.regFault[3] = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutFrm = new AboutBox1();
            aboutFrm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show
                (" Are you really want to exit?", "Confirm Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if( exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
