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
using System.Diagnostics;
using System.IO;

namespace LED_Handheld_Project.Forms
{
    public partial class Device : Form
    {
        int bar_val;
        int data;
        string save_path;
        string save_path_buff;
        string content;
        string data_file;
        Stopwatch s = new Stopwatch();


        System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        public Device()
        {
            InitializeComponent();
        }

        private void Device_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("0");
                serialPort1.Close();
            }
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


        void sd_space_event_wait()
        {
            int data = 0;
            double free_space_val=0.0;
            double max_space_val=100.0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (data!=3)
            {
                if (int.TryParse(serialPort1.ReadLine(),out data))
                {
                    while(data == 1)
                    {
                        if (double.TryParse(serialPort1.ReadLine(), System.Globalization.NumberStyles.Any, culture, out free_space_val) && free_space_val!=1)
                        {
                            break;
                        }
                    }
                    while(data == 2)
                    {
                        if (double.TryParse(serialPort1.ReadLine(), System.Globalization.NumberStyles.Any, culture,out max_space_val)&& max_space_val !=1)
                        {
                            if(free_space_val>max_space_val)
                            {
                                free_space_val = max_space_val;
                            }
                            break;
                        }
                    }
                }
            }
            bar_val = Convert.ToInt16(free_space_val / max_space_val * 100.0);
            SD_space_progress_bar.Minimum = 0;
            SD_space_progress_bar.Maximum = 100;
            SD_space_progress_bar.SubscriptText = free_space_val + "/";
            SD_space_progress_bar.SuperscriptText = max_space_val + "GB";
        }

        private void SD_space_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("5");
                using (Form_progress frm = new Form_progress(sd_space_event_wait))
                {
                    frm.ShowDialog(this);
                }
                SD_space_progress_bar.Value = bar_val;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        
        void clear_event_wait()
        {
            int data = 0;
            while (data != 1)
            {
                int.TryParse(serialPort1.ReadLine(), out data);
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("4");
                using(Form_progress frm = new Form_progress(clear_event_wait))
                {
                    frm.ShowDialog(this);
                }
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void record_10s_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("3");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        void import_event_wait()
        {
            while(data!=5)
            {
                int data_buff;
                string data_in = serialPort1.ReadLine();
                if (!int.TryParse(data_in, out data_buff))
                {
                    import_state(data, data_in);
                }
                else if (data == 4)
                {
                    import_state(data, data_in);
                    data = data_buff;
                }
                else
                    data = data_buff;
            }
            serialPort1.Write("0");
        }
        private void button_import_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("");
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    save_path = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
                serialPort1.Write("6");
                using (Form_progress frm = new Form_progress(import_event_wait))
                {
                    frm.ShowDialog(this);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void import_state(int data, string data_in)
        {
            switch (data)
            {
                case 1:
                    try
                    {
                        if (data_in.Length > 0)
                        {
                            save_path_buff = save_path + data_in;
                            if (!Directory.Exists(save_path_buff.Replace("\n", "").Replace("\r", "")))
                            {
                                Directory.CreateDirectory(save_path_buff.Replace("\n", "").Replace("\r", ""));
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                    break;
                case 2:
                    try
                    {
                        data_file = data_in;
                    } catch(Exception)
                    {

                    }
                    break;
                case 3:
                    content += data_in;
                    break;
                case 4:
                    try
                    {
                        string file_save_path = save_path_buff + "\\" + data_file;
                        File.WriteAllText(file_save_path.Replace("\n", "").Replace("\r", ""), content);
                        content = "";
                    } catch(Exception)
                    {
                    }
                    break;
            }
        }

        private void button_import_clear_Click(object sender, EventArgs e)
        {
            button_import_Click(sender, e);
            button_clear_Click(sender, e);
        }
    }
}
