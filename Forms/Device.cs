using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LED_Handheld_Project.Forms
{
    public partial class Device : Form
    {
        public Device()
        {
            InitializeComponent();
        }

        private void cb_port_select_DropDown(object sender, EventArgs e)
        {
            string[] portlist = SerialPort.GetPortNames();
            cb_port_select.Items.Clear();
            cb_port_select.Items.AddRange(portlist);
        }

        private void cb_port_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cb_port_select.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void SD_space_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                SD_space_progress_bar.Minimum = 0;
                String max_val = serialPort1.ReadLine();
                textBox_test.Text = max_val;
                SD_space_progress_bar.Maximum = 100;
                String val = serialPort1.ReadLine();
                textBox_test2.Text = val;
                int bar_val = Convert.ToInt16(double.Parse(val) / double.Parse(max_val) * 100.0) ;
                SD_space_progress_bar.Value = bar_val;
                SD_space_progress_bar.SubscriptText = val + "/";
                SD_space_progress_bar.SuperscriptText = max_val + "GB";

            } catch
            {
                return;
            }
         }
    }
}
