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
    public partial class FormReal : Form
    {
        //Fields
        string in_data;
        static sbyte indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI, indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP;
        static string Temperature, Humidity, V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3;

        sbyte[] index_sep = new sbyte[] { indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI,
            indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP};

        string[] sep_string = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P"};

        string[] voltages = new string[] { V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3};
        string[] voltage_name = new string[] { "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "VRef1", "VRef2", "VOut1", "VOut2", "VOut3" };

        CheckBox[] cek_V;

        private void lbOperator_Click(object sender, EventArgs e)
        {

        }

        static kayChart serialDataChartV1, serialDataChartV2, serialDataChartV3, serialDataChartV4, serialDataChartV5,
            serialDataChartV6, serialDataChartV7, serialDataChartV8, serialDataChartV9,
            serialDataChartVRef1, serialDataChartVRef2,
            serialDataChartVOut1, serialDataChartVOut2, serialDataChartVOut3; // untuk Grafik

        kayChart[] chart_V = new kayChart[]
        {serialDataChartV1, serialDataChartV2, serialDataChartV3, serialDataChartV4, serialDataChartV5,
            serialDataChartV6, serialDataChartV7, serialDataChartV8, serialDataChartV9,
            serialDataChartVRef1, serialDataChartVRef2,
            serialDataChartVOut1, serialDataChartVOut2, serialDataChartVOut3
        };

        public FormReal()
        {
            InitializeComponent();

            cek_V = new CheckBox[] { cekV1, cekV2, cekV3, cekV4, cekV5, cekV6, cekV7, cekV8, cekV9, cekVRef1, cekVRef2, cekVOut1, cekVOut2, cekVOut3};
        }

        private void FormReal_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnHold.Enabled = false;
            rtbSerialData.Visible = false;
            string[] ports = SerialPort.GetPortNames(); // untuk ports
            cbPort.Items.AddRange(ports); // untuk ports
            //untuk grafik
            ResetGraph();

            for (int i = 0; i < 14; i++)
            {
                chart_V[i] = new kayChart(chartData, 150);
                chart_V[i].serieName = voltage_name[i];
            } //chart naming and initializer
        }

        private void ResetGraph()
        {
            for(int i=0; i<14; i++)
                chartData.Series[voltage_name[i]].Enabled = false;
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
            foreach (Control tboxs in this.Controls)
            {
                if (tboxs.GetType() == typeof(TextBox))
                {
                    TextBox tbox = (TextBox)tboxs;
                    tbox.BackColor = Color.FromArgb(34, 33, 74);
                    tbox.ForeColor = Color.FromArgb(172, 126, 241);//FromArgb(172, 126, 241);
                }
            }
            tbOperator.BackColor= Color.FromArgb(172, 126, 241);
            tbOperator.ForeColor = Color.White;
            tbModule.BackColor = Color.FromArgb(172, 126, 241);
            tbModule.ForeColor = Color.White;
            //lbPort.ForeColor = Color.White;
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
                Humidity = in_data.Substring(indexOfA + 1, (index_sep[2] - index_sep[1]) - 1);

                for (int i = 0; i < 14; i++)
                {
                    voltages[i] = in_data.Substring(index_sep[i + 1] + 1, (index_sep[i + 2] - index_sep[i + 1]) - 1);
                }

                //Display text
                tbDate.Text = DateTime.Now.ToString("G");
                tbTemperature.Text = ": " + Temperature + " °C";
                tbHumidity.Text = ": " + Humidity + " %";
                string time = DateTime.Now.ToString("HH" + ':' + "mm" + ':' + "ss");
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText(time + "," + Temperature + "," + Humidity + "," + V1 + "," + V2 + "," + V3 + "," + V4 + "," + V5 + "," + V6 + "," + V7 + "," + V8 + "," + V9 + "," + VRef1 + "," + VRef2 + "," + VOut1 + "," + VOut2 + "," + VOut3 + "\r"); });
                ProcessGraph();
                /*text_V1.Text = V1;
                text_V2.Text = V2;
                text_V3.Text = V3;
                text_V4.Text = V4;
                text_V5.Text = V5;
                text_V6.Text = V6;
                text_V7.Text = V7;
                text_V8.Text = V8;
                text_V9.Text = V9;
                text_VOut1.Text = VOut1;
                text_VOut2.Text = VOut2;
                text_VOut3.Text = VOut3;
                text_VRef1.Text = VRef1;
                text_VRef2.Text = VRef2;
                text_VRef3.Text = VRef3;*/
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ProcessGraph()
        {
            double data_V;
            for (int i = 0; i < 14; i++)
            {
                bool result_V = double.TryParse(voltages[i], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_V);
                if(result_V && cek_V[i].Checked == true)
                {
                    chartData.Series[voltage_name[i]].Enabled = true;
                    chart_V[i].TriggeredUpdate(data_V);
                }
                else
                {
                    chart_V[i].TriggeredUpdate(data_V);
                    chartData.Series[voltage_name[i]].Enabled = false;
                }
            }
        }

        //Button Method
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnHold.Enabled = true;
            try
            {
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            catch (Exception error)
            {
                ProcessData(sender, e);
                MessageBox.Show(error.Message);
            }
        }

        private void rtbSerialData_TextChanged(object sender, EventArgs e)
        {
            rtbSerialData.SelectionStart = rtbSerialData.Text.Length;
            rtbSerialData.ScrollToCaret();
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnHold.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyyMMddTHHmmss");
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
                string location = saveFileDialog1.FileName;
                string dataSave = DateTime.Now.ToString("yyyy/MM/dd") + "\r" + tbModule.Text + "\r" + tbOperator.Text + "\r" + rtbSerialData.Text + "\r"+rtbSerialData.Text;
                System.IO.File.WriteAllText(location, dataSave);
                MessageBox.Show("Data has been saved");
            }
        }

        private void btnGridTable_Click(object sender, EventArgs e)
        {
            if (chartData.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled == false)
            {
                chartData.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = true;
                chartData.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = true;
                btnGridTable.Text = "Grid ON";
            }
            else
            {
                chartData.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chartData.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                btnGridTable.Text = "Grid OFF";
            }
        }

    }
}
