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
using rtChart;
using System.Globalization;

namespace LED_Handheld_Project.Forms
{
    public partial class FormProduct : Form
    {
        //Fields
        string in_data;
        static sbyte indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI, indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP;

        

        static string Temperature, Humidity, V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3;

        

        sbyte[] index_sep = new sbyte[] { indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI,
            indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP};

        string[] sep_string = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };

        string[] voltages = new string[] { V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3 };
        string[] voltage_name = new string[] { "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "VRef1", "VRef2", "VOut1", "VOut2", "VOut3" };

        CheckBox[] cek_V;
        TextBox[] value;
        TextBox[] result;

        public FormProduct()
        {
            InitializeComponent();
            //cek_V = new CheckBox[] { cekV1, cekV2, cekV3, cekV4, cekV5, cekV6, cekV7, cekV8, cekV9, cekVRef1, cekVRef2, cekVOut1, cekVOut2, cekVOut3 };
            value = new TextBox[] { valV1, valV2, valV3, valV4, valV5, valV6, valV7, valV8, valV9, valVRef1, valVRef2, valVOut1, valVOut2, valVOut3 };
            result = new TextBox[] { resV1, resV2, resV3, resV4, resV5, resV6, resV7, resV8, resV9, resVRef1, resVRef2, resVOut1, resVOut2, resVOut3 };
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnStop.Enabled = false;
            rtbSerialData.Visible = false;
            string[] ports = SerialPort.GetPortNames(); // untuk ports
            cbPort.Items.AddRange(ports); // untuk ports
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(172, 126, 241);
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(172, 126, 241);
                    //btn.Size= new System.Drawing.Size(100, 40);
                }
            }
            foreach (Control labs in this.Controls)
            {
                if (labs.GetType() == typeof(Label))
                {
                    Label lab = (Label)labs;
                    lab.BackColor = Color.Transparent;
                    lab.ForeColor = Color.White;
                }
            }
            /*foreach (Control tboxs in this.Controls)
            {
                if (tboxs.GetType() == typeof(TextBox))
                {
                    TextBox tbox = (TextBox)tboxs;
                    tbox.BackColor = Color.FromArgb(34, 33, 74);
                    tbox.ForeColor = Color.FromArgb(172, 126, 241); ;//FromArgb(172, 126, 241);
                }
            }
            tbOperator.BackColor = Color.FromArgb(172, 126, 241);
            tbOperator.ForeColor = Color.White;
            tbModule.BackColor = Color.FromArgb(172, 126, 241);
            tbModule.ForeColor = Color.White;
            lbPort.ForeColor = Color.White;*/
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
            btnStop.Enabled = true;
            try
            {
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                in_data = serialPort1.ReadLine();
                this.BeginInvoke(new EventHandler(ProcessData));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                //convert nilai index
                for (int i = 0; i < 16; i++)
                    index_sep[i] = Convert.ToSByte(in_data.IndexOf(sep_string[i]));

                //pembacaan nilai
                Temperature = in_data.Substring(0, index_sep[0]);
                Humidity = in_data.Substring(index_sep[0] + 1, (index_sep[2] - index_sep[1]) - 1);

                for (int i = 0; i < 14; i++)
                    voltages[i] = in_data.Substring(index_sep[i + 1] + 1, (index_sep[i + 2] - index_sep[i + 1]) - 1);

                //Display text
                tbDate.Text = DateTime.Now.ToString("G");
                tbTemperature.Text = ": " + Temperature + " °C";
                tbHumidity.Text = ": " + Humidity + " %";
                string time = DateTime.Now.ToString("HH" + ':' + "mm" + ':' + "ss");
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText(time + "," + Temperature + "," + Humidity + "," + V1 + "," + V2 + "," + V3 + "," + V4 + "," + V5 + "," + V6 + "," + V7 + "," + V8 + "," + V9 + "," + VRef1 + "," + VRef2 + "," + VOut1 + "," + VOut2 + "," + VOut3 + "\r"); });
                DisplayValue();
                ProcessValue();
                /*text_V1.Text = V1;*/
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DisplayValue()
        {
            tbDate.Text = DateTime.Now.ToString("G");
            tbTemperature.Text = ": " + Temperature + " °C";
            tbHumidity.Text = ": " + Humidity + " %";
            valTemperature.Text = "  " + Temperature + " °C";
            valHumidity.Text = "  " + Humidity + " %";
            for (int i = 0; i < 14; i++)
                value[i].Text = voltages[i];
            string time = DateTime.Now.ToString("HH" + ':' + "mm" + ':' + "ss");
            rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText(time + "," + Temperature + "," + Humidity + "," + V1 + "," + V2 + "," + V3 + "," + V4 + "," + V5 + "," + V6 + "," + V7 + "," + V8 + "," + V9 + "," + VRef1 + "," + VRef2 + "," + VOut1 + "," + VOut2 + "," + VOut3 + "\r"); });
        }

        private void ProcessValue()
        {
            for (int i = 0; i < 9; i++)
            {
                double data_V;
                bool result_V = double.TryParse(voltages[i], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_V);
                if (result_V )
                {
                    if(data_V >= 11.8 && data_V <= 12.2)
                    {
                        result[i].Text = "OK";
                        result[i].BackColor = Color.Green;
                    }
                    else
                    {
                        result[i].Text = "NOK";
                        result[i].BackColor = Color.Red;
                    }
                }
            }
            double data_V9;//VRef1
            bool result_V9 = double.TryParse(voltages[9], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_V9);
            if (result_V9)
            {
                if (data_V9 >= 6.3 && data_V9 <= 6.7)
                {
                    result[9].Text = "OK";
                    result[9].BackColor = Color.Green;
                }
                else
                {
                    result[9].Text = "NOK";
                    result[9].BackColor = Color.Red;
                }
            }
            double data_VRef2;//VRef2
            bool result_VRef2 = double.TryParse(voltages[10], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_VRef2);
            if (result_VRef2)
            {
                if (data_VRef2 >= 5.3 && data_VRef2 <= 5.7)
                {
                    result[10].Text = "OK";
                    result[10].BackColor = Color.Green;
                }
                else
                {
                    result[10].Text = "NOK";
                    result[10].BackColor = Color.Red;
                }
            }
            for (int i = 11; i < 14; i++)
            {
                double data_V;
                bool result_V = double.TryParse(voltages[i], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_V);
                if (result_V)
                {
                    if (data_V >= 7.8 && data_V <= 8.2)
                    {
                        result[i].Text = "OK";
                        result[i].BackColor = Color.Green;
                    }
                    else
                    {
                        result[i].Text = "NOK";
                        result[i].BackColor = Color.Red;
                    }
                }
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("ddMMyyyyTHHmmss");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\%USERNAME%\Documents\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.FileName = time + " Data Logger with " + tbModule.Text + " by " + tbOperator.Text;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "Text files (*.csv)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] contents = new string[21];
                contents[0] = "Date" + "," + DateTime.Now.ToString("yyyy/MM/dd");
                contents[1] = "Module ID" + "," + tbModule.Text;
                contents[2] = "Operator ID" + "," + tbOperator.Text;
                contents[3] = "Temperature" + "," + Temperature;
                contents[4] = "Humidity" + "," + Humidity;
                contents[5] = "" + "," + "Volts" + "," + "Results";
                for (int i = 0; i < 14; i++)
                    contents[i + 6] = voltage_name[i] + "," + value[i].Text + "," + result[i].Text;
                //contents[20] = "Test Result" + "," + text_TestResult.Text;
                string location = saveFileDialog1.FileName;
                //string datasave = DateTime.Now.ToString("dd/MM/yyyy") + "\r" + textModuleID.Text + "\r" + textOperatorID.Text + "\r";
                System.IO.File.WriteAllLines(location, contents);
                MessageBox.Show("Data has been saved");
            }
        }
    }
}
