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
    public partial class FormRealTime : Form
    {
        //Fields
        //private Form activeForm;
        private SerialPort myport; // untuk ports
        kayChart serialDataChart1; // untuk Grafik
        kayChart serialDataChart2; // untuk Grafik
        kayChart serialDataChart3; // untuk Grafik
        kayChart serialDataChart4; // untuk Grafik
        kayChart serialDataChart5; // untuk Grafik
        kayChart serialDataChart6; // untuk Grafik
        kayChart serialDataChart7; // untuk Grafik
        kayChart serialDataChart8; // untuk Grafik
        kayChart serialDataChart9; // untuk Grafik
        kayChart serialDataChart10; // untuk Grafik
        kayChart serialDataChart11; // untuk Grafik
        kayChart serialDataChart12; // untuk Grafik
        kayChart serialDataChart13; // untuk Grafik
        kayChart serialDataChart14; // untuk Grafik
        string[] recvData;

        public FormRealTime()
        {
            InitializeComponent();
        }

        private void FormRealTime_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnStop.Enabled = false;
            //rtbSerialData.Visible = false;
            tbDate.Text = DateTime.Now.ToString("G");
            string[] ports = SerialPort.GetPortNames(); // untuk ports
            cbPort.Items.AddRange(ports); // untuk ports
            //untuk grafik
            serialDataChart1 = new kayChart(chartData, 150);
            serialDataChart1.serieName = "V1";
            serialDataChart2 = new kayChart(chartData, 150);
            serialDataChart2.serieName = "V2";
            serialDataChart3 = new kayChart(chartData, 150);
            serialDataChart3.serieName = "V3";
            serialDataChart4 = new kayChart(chartData, 150);
            serialDataChart4.serieName = "V4";
            serialDataChart5 = new kayChart(chartData, 150);
            serialDataChart5.serieName = "V5";
            serialDataChart6 = new kayChart(chartData, 150);
            serialDataChart6.serieName = "V6";
            serialDataChart7 = new kayChart(chartData, 150);
            serialDataChart7.serieName = "V7";
            serialDataChart8 = new kayChart(chartData, 150);
            serialDataChart8.serieName = "V8";
            serialDataChart9 = new kayChart(chartData, 150);
            serialDataChart9.serieName = "V9";
            serialDataChart10 = new kayChart(chartData, 150);
            serialDataChart10.serieName = "VOut1";
            serialDataChart11 = new kayChart(chartData, 150);
            serialDataChart11.serieName = "VOut2";
            serialDataChart12 = new kayChart(chartData, 150);
            serialDataChart12.serieName = "VOut3";
            serialDataChart13 = new kayChart(chartData, 150);
            serialDataChart13.serieName = "VRef1";
            serialDataChart14 = new kayChart(chartData, 150);
            serialDataChart14.serieName = "VRef2";
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
            //lbMeasurement.ForeColor = ThemeColor.PrimaryColor;
        }

        //Button Method
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            try
            {
                //serialPort1.ReadLine();
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = cbPort.Text;
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
                myport.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Update data
        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //SerialPort sData = sender as SerialPort;
                //recvData = sData.ReadLine().Split((char)',');
                //recvData = serialPort1.ReadLine().Split((char)',');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            string time = DateTime.Now.ToString("HH"+':'+"mm"+':'+"ss");

            // Bagian Pemisahan dan Checking data ada atau tidak
            double data0;//Temperature
            bool result0 = double.TryParse(recvData[0], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data0);
            if (result0)
            {
                serialDataChart1.TriggeredUpdate(data0);//Grafik Tp engga masuk nanti
                //tbTemperature.Text = recvData[0];
                tbTemperature.Invoke((MethodInvoker)delegate { tbTemperature.AppendText(recvData[0] + "\n"); });
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText(time + "," + recvData[0]); });
            }

            double data1;//Humidity
            bool result1 = double.TryParse(recvData[1], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data1);
            if (result1)
            {
                tbHumidity.Invoke((MethodInvoker)delegate { tbHumidity.AppendText(recvData[1] + "\n"); });
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[1]); });
                serialDataChart2.TriggeredUpdate(data1);
            }
            double data2;//V1
            bool result2 = double.TryParse(recvData[2], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data2);
            if (result2)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[2]); });
                serialDataChart1.TriggeredUpdate(data2);
            }
            double data3;//V2
            bool result3 = double.TryParse(recvData[3], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data3);
            if (result3)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[3]); });
                serialDataChart2.TriggeredUpdate(data3);
            }
            double data4;//V3
            bool result4 = double.TryParse(recvData[4], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data4);
            if (result4)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[4]); });
                serialDataChart3.TriggeredUpdate(data4);
            }
            double data5;//V4
            bool result5 = double.TryParse(recvData[5], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data5);
            if (result5)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[5]); });
                serialDataChart4.TriggeredUpdate(data5);
            }
            double data6;//V5
            bool result6 = double.TryParse(recvData[6], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data6);
            if (result6)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[6]); });
                serialDataChart5.TriggeredUpdate(data6);
            }
            double data7;//V6
            bool result7 = double.TryParse(recvData[7], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data7);
            if (result7)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[7]); });
                serialDataChart6.TriggeredUpdate(data7);
            }
            double data8;//V7
            bool result8 = double.TryParse(recvData[8], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data8);
            if (result3)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[8]); });
                serialDataChart7.TriggeredUpdate(data8);
            }
            double data9;//V8
            bool result9 = double.TryParse(recvData[9], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data9);
            if (result9)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[9]); });
                serialDataChart8.TriggeredUpdate(data9);
            }
            double data10;//V9
            bool result10 = double.TryParse(recvData[10], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data10);
            if (result10)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[10]); });
                serialDataChart9.TriggeredUpdate(data10);
            }
            double data11;//VOut1
            bool result11 = double.TryParse(recvData[11], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data11);
            if (result11)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[11]); });
                serialDataChart10.TriggeredUpdate(data11);
            }
            double data12;//VOut2
            bool result12 = double.TryParse(recvData[12], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data12);
            if (result12)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[12]); });
                serialDataChart11.TriggeredUpdate(data12);
            }
            double data13;//VOut3
            bool result13 = double.TryParse(recvData[13], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data13);
            if (result3)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[13]); });
                serialDataChart12.TriggeredUpdate(data13);
            }
            double data14;//VRef1
            bool result14 = double.TryParse(recvData[14], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data14);
            if (result14)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[14]); });
                serialDataChart13.TriggeredUpdate(data14);
            }
            double data15;//VRef2
            bool result15 = double.TryParse(recvData[15], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data15);
            if (result15)
            {
                rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText("," + recvData[15] + "\r"); });
                serialDataChart14.TriggeredUpdate(data15);
                //rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText(time + "," + recvData[0] + "," + recvData[1] + "," + recvData[2] + "," + recvData[3] + "," + recvData[4] + "," + recvData[5] + "," + recvData[6] + "," + recvData[7] + "," + recvData[8] + "," + recvData[9] + "," + recvData[10] + "," + recvData[11] + "," + recvData[12] + "," + recvData[13] + "\r"); });
            }
            //Menulis data

        }

        private void rtbSerialData_TextChanged(object sender, EventArgs e)
        {
            rtbSerialData.SelectionStart = rtbSerialData.Text.Length;
            rtbSerialData.ScrollToCaret();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            try
            {
                //serialPort1.Close()
                myport.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Terjadi Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyyMMddTHHmmss");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\%USERNAME%\Documents\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.FileName = time + " Data Logger with "+tbModule.Text+" by " + tbOperator.Text;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string location = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(location, rtbSerialData.Text);
                MessageBox.Show("Data has been saved");
            }
        }

        
    }
}
