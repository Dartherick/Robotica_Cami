using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShooterBot
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<string> MessageList = new List<string>();
        public Form1()
        {    //Inicializando hmi
            InitializeComponent();

            string[] PortList = SerialPort.GetPortNames(); //mejorar aqui
            Port_ComboBox.Items.AddRange(PortList);

            string[] BaudRatesList = { "9600", "38400", "57600", "115200" };
            BaudRate_ComboBox.DataSource = BaudRatesList;
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPortConnection.PortName = Port_ComboBox.Text;
                SerialPortConnection.BaudRate = Convert.ToInt32(BaudRate_ComboBox.Text);
                SerialPortConnection.Open();
                ProgressBar.Value = 100;
                CloseButton.Enabled = true;
                OpenButton.Enabled = false;
                RefreshButton.Enabled = false;
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            string[] PortList = SerialPort.GetPortNames();
            Port_ComboBox.Items.AddRange(PortList);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (SerialPortConnection.IsOpen)
            {
                try
                {
                    SerialPortConnection.Close();
                    ProgressBar.Value = 0;
                    CloseButton.Enabled = false;
                    OpenButton.Enabled = true;
                    RefreshButton.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void GreenRectangularButton_Click(object sender, EventArgs e)
        {
            i += 1;
            GreenRectangularButton.Enabled = false;
            GreenRectangularButton.Text = i.ToString();

            MessageList.Add("RG");

            if (i == 3)
            {
                GreenCircularButton.Enabled = false;
                GreenRectangularButton.Enabled = false;
                RedCircularButton.Enabled = false;
                RedTriangularButton.Enabled = false;
                BlueRectangularButton.Enabled = false;
                BlueTriangularButton.Enabled = false;
            }
        }

        private void RedTriangularButton_Click(object sender, EventArgs e)
        {
            i += 1;
            RedTriangularButton.Enabled = false;
            RedTriangularButton.Text = i.ToString();

            MessageList.Add("TR");

            if (i == 3)
            {
                GreenCircularButton.Enabled = false;
                GreenRectangularButton.Enabled = false;
                RedCircularButton.Enabled = false;
                RedTriangularButton.Enabled = false;
                BlueRectangularButton.Enabled = false;
                BlueTriangularButton.Enabled = false;
            }
        }

        private void BlueTriangularButton_Click(object sender, EventArgs e)
        {
            i += 1;
            BlueTriangularButton.Enabled = false;
            BlueTriangularButton.Text = i.ToString();

            MessageList.Add("TB");

            if (i == 3)
            {
                GreenCircularButton.Enabled = false;
                GreenRectangularButton.Enabled = false;
                RedCircularButton.Enabled = false;
                RedTriangularButton.Enabled = false;
                BlueRectangularButton.Enabled = false;
            }
        }

        private void BlueRectangularButton_Click(object sender, EventArgs e)
        {
            i += 1;
            BlueRectangularButton.Enabled = false;
            BlueRectangularButton.Text = i.ToString();

            MessageList.Add("RB");

            if (i == 3)
            {
                GreenCircularButton.Enabled = false;
                GreenRectangularButton.Enabled = false;
                RedCircularButton.Enabled = false;
                RedTriangularButton.Enabled = false;
                BlueTriangularButton.Enabled = false;
            }
        }

        private void GreenCircularButton_Click(object sender, EventArgs e)
        {
            i += 1;
            GreenCircularButton.Enabled = false;
            GreenCircularButton.Text = i.ToString();

            MessageList.Add("CG");

            if (i == 3)
            {
                GreenRectangularButton.Enabled = false;
                RedCircularButton.Enabled = false;
                RedTriangularButton.Enabled = false;
                BlueRectangularButton.Enabled = false;
                BlueTriangularButton.Enabled = false;
            }
        }

        private void RedCircularButton_Click(object sender, EventArgs e)
        {
            i += 1;
            RedCircularButton.Enabled = false;
            RedCircularButton.Text = i.ToString();

            MessageList.Add("CR");

            if (i == 3)
            {
                GreenCircularButton.Enabled = false;
                GreenRectangularButton.Enabled = false;
                RedTriangularButton.Enabled = false;
                BlueRectangularButton.Enabled = false;
                BlueTriangularButton.Enabled = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            i = 0;
            MessageList.Clear();

            GreenCircularButton.Enabled = true;
            GreenRectangularButton.Enabled = true;
            RedCircularButton.Enabled = true;
            RedTriangularButton.Enabled = true;
            BlueRectangularButton.Enabled = true;
            BlueTriangularButton.Enabled = true;
            
            GreenCircularButton.Text = "";
            GreenRectangularButton.Text = "";
            RedCircularButton.Text = "";
            RedTriangularButton.Text = "";
            BlueRectangularButton.Text = "";
            BlueTriangularButton.Text = "";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string Message = "<" + string.Join(",", MessageList) + ">";
            MessageBox.Show(Message);

            try
            {
                SerialPortConnection.WriteLine(Message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialPortConnection.IsOpen)
            {
                try
                {
                    SerialPortConnection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
