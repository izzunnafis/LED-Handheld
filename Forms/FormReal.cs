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
        static string Temperature, Humidity, V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3;
        string in_data;
        string[] in_data_list;      

        string[] voltages = new string[] { V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3};
        string[] voltage_name = new string[] { "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "VRef1", "VRef2", "VOut1", "VOut2", "VOut3" };

        CheckBox[] cek_V;
        Label[] label_V;

        int data_iter = 1;

        static kayChart serialDataChartV1, serialDataChartV2, serialDataChartV3, serialDataChartV4, serialDataChartV5,
            serialDataChartV6, serialDataChartV7, serialDataChartV8, serialDataChartV9,
            serialDataChartVRef1, serialDataChartVRef2,
            serialDataChartVOut1, serialDataChartVOut2, serialDataChartVOut3, dummy_chart; // untuk Grafik

        kayChart[] chart_V = new kayChart[]
        {serialDataChartV1, serialDataChartV2, serialDataChartV3, serialDataChartV4, serialDataChartV5,
            serialDataChartV6, serialDataChartV7, serialDataChartV8, serialDataChartV9,
            serialDataChartVRef1, serialDataChartVRef2,
            serialDataChartVOut1, serialDataChartVOut2, serialDataChartVOut3, dummy_chart
        };


        public FormReal()
        {
            InitializeComponent();

            cek_V = new CheckBox[] { cekV1, cekV2, cekV3, cekV4, cekV5, cekV6, cekV7, cekV8, cekV9, cekVRef1, cekVRef2, cekVOut1, cekVOut2, cekVOut3};
            label_V = new Label[] { lbV1, lbV2, lbV3, lbV4, lbV5, lbV6, lbV7, lbV8, lbV9, lbVRef1, lbVRef2, lbVOut1, lbVOut2, lbVOut3 };

        }

        private void FormReal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write("0");
                serialPort1.Close();
            }
        }

        private void FormReal_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnHold.Enabled = false;
            rtbSerialData.Visible = false;
            tbDateValue.Visible = false;
            //hideVisible();
            string[] ports = SerialPort.GetPortNames(); // untuk ports
            cbPort.Items.AddRange(ports); // untuk ports
            //untuk grafik
            ResetGraph();

            for (int i = 0; i < 14; i++)
            {
                chart_V[i] = new kayChart(chartData, 150);
                chart_V[i].serieName = voltage_name[i];
            } //chart naming and initializer
            chart_V[14] = new kayChart(chartData, 150);
            chart_V[14].serieName = "Bar List";
            chart_V[14].TriggeredUpdate(0.0);
            
        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(serialPort1.PortName!=cbPort.Text)
            {
                serialPort1.Close();
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
        }

        private void cboxLampType_TextChanged(object sender, EventArgs e)
        {
            if (cboxLampType.Text == "V3.0" || cboxLampType.Text == "V3.1")
            {
                for (int i = 0; i < 14; i++)
                {
                    label_V[i].Visible = true;
                    cek_V[i].Visible = true;
                }
            }
            else if(cboxLampType.Text == "V4.0")
            {
                for (int i = 0; i < 2; i++)
                {
                    label_V[i].Visible = true;
                    cek_V[i].Visible = true;
                }
                for (int i = 2; i < 9; i++)
                {
                    label_V[i].Visible = false;
                    cek_V[i].Visible = false;
                    cek_V[i].Checked = false;
                }
                for (int i = 9; i < 14; i++)
                {
                    label_V[i].Visible = true;
                    cek_V[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < 14; i++)
                {
                    label_V[i].Visible = false;
                    cek_V[i].Visible = false;
                    cek_V[i].Checked = false;
                }
            }
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
                in_data_list = in_data.Split(',');
                if(in_data_list.Length>=10)
                {
                    Temperature = in_data_list[2];
                    Humidity = in_data_list[3];

                    for(int i=0; i<14; i++)
                    {
                        voltages[i] = in_data_list[i + 4];
                    }
                }

                //Display text
                tbDateValue.Clear();
                tbDateValue.Visible = true;
                tbDateValue.Text = DateTime.Now.ToString("ddd, dd MMM yyyy");
                tbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                tbTemperature.Text = Temperature + " °C";
                tbHumidity.Text = Humidity + " %";
                string time = DateTime.Now.ToString("HH" + ':' + "mm" + ':' + "ss");
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText(data_iter + "," + time + "," + Temperature + "," + Humidity + "," + voltages[0] + "," + voltages[1] + "," + voltages[2] + "," + voltages[3] + "," + voltages[4] + "," + voltages[5] + "," + voltages[6] + "," + voltages[7] + "," + voltages[8] + "," + voltages[9] + "," + voltages[10] + "," + voltages[11] + "," + voltages[12] + "," + voltages[13] + "\r"); });
                data_iter++;
                ProcessGraph();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ProcessGraph()
        {
            for (int i = 0; i < 14; i++)
            {
                double data_V;
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
        
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                btnStart.Enabled = false;
                btnHold.Enabled = true;
                data_iter = 1;
                openVisible();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void openVisible()
        {
            tbHumidity.Visible = true;
            tbTemperature.Visible = true;
            lbTemperature.Visible = true;
            lbHumidity.Visible = true;

        }

        private void hideVisible()
        {
            tbHumidity.Visible = false;
            tbTemperature.Visible = false;
            lbTemperature.Visible = false;
            lbHumidity.Visible = false;
        }

        private void rtbSerialData_TextChanged(object sender, EventArgs e)
        {
            rtbSerialData.SelectionStart = rtbSerialData.Text.Length;
            rtbSerialData.ScrollToCaret();
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            try
            {
                btnStart.Enabled = true;
                btnHold.Enabled = false;
                serialPort1.Write("0");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyyMMddTHHmmss");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\%USERNAME%\Documents\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.FileName = time + " Data Logger with " + tbSerialNumber.Text + " by " + tbOperator.Text;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "Text files (*.csv)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if(rtbSerialData.Text.Length>0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string location = saveFileDialog1.FileName;
                    string[] contents = new string[5];
                    contents[0] = "Date" + "," + DateTime.Now.ToString("yyyy/MM/dd");
                    contents[1] = "Device Number" + "," + tbSerialNumber.Text;
                    contents[2] = "Operator Number" + "," + tbOperator.Text;
                    contents[3] = "No" + "," + "Timestamp" + "," + "Temperature" + "," + "Humidity" + "," + "V1" + "," + "V2" + "," + "V3" + ","
                        + "V4" + "," + "V5" + "," + "V6" + "," + "V7" + "," + "V8" + "," + "V9" + "," + "Vref1" + "," + "V1ref2"
                        + "," + "Vout1" + "," + "Vout2" + "," + "Vout3";
                    contents[4] = rtbSerialData.Text;
                    rtbSerialData.Text="";
                    System.IO.File.WriteAllLines(location, contents);
                    MessageBox.Show("Data has been saved");

                }
            }
            else
                MessageBox.Show("Data is Empty");
            data_iter = 1;
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
