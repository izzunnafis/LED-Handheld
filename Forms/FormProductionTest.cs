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
using System.Globalization;

namespace LED_Handheld_Project.Forms
{
    public partial class FormProductionTest : Form
    {
        //Fields
        string in_data;
        sbyte indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI, indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP, indexOfQ;

        private void lbTemperature_Click(object sender, EventArgs e)
        {

        }

        string Temperature, Humidity, V1, V2, V3, V4, V5, V6, V7, V8, V9, VOut1, VOut2, VOut3, VRef1, VRef2,VRef3;

        public FormProductionTest()
        {
            InitializeComponent();
        }

        private void FormProductionTest_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnStop.Enabled = false;
            //rtbSerialData.Visible = false;
            tbDate.Text = DateTime.Now.ToString("G");
            string[] ports = SerialPort.GetPortNames(); // untuk ports
            cbPort.Items.AddRange(ports); // untuk ports
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
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            btnStop.Enabled = false;
            resetResult();
            try
            {
                serialPort1.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void resetResult()
        {
            resV1.BackColor = Color.White;
            resV2.BackColor = Color.White;
            resV3.BackColor = Color.White;
            resV4.BackColor = Color.White;
            resV5.BackColor = Color.White;
            resV6.BackColor = Color.White;
            resV7.BackColor = Color.White;
            resV8.BackColor = Color.White;
            resV9.BackColor = Color.White;
            resVRef1.BackColor = Color.White;
            resVRef2.BackColor = Color.White;
            resVOut1.BackColor = Color.White;
            resVOut2.BackColor = Color.White;
            resVOut3.BackColor = Color.White;
            resV1.Text = "";
            resV2.Text = "";
            resV3.Text = "";
            resV4.Text = "";
            resV5.Text = "";
            resV6.Text = "";
            resV7.Text = "";
            resV8.Text = "";
            resV9.Text = "";
            resVRef1.Text = "";
            resVRef2.Text = "";
            resVOut1.Text = "";
            resVOut2.Text = "";
            resVOut3.Text = "";
        }

        private void rtbSerialData_TextChanged(object sender, EventArgs e)
        {
            rtbSerialData.SelectionStart = rtbSerialData.Text.Length;
            rtbSerialData.ScrollToCaret();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(24, 161, 251);
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(24, 161, 251);
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
                    tbox.ForeColor = Color.FromArgb(24, 161, 251);//FromArgb(172, 126, 241);
                }
            }*/
            tbOperator.BackColor = Color.FromArgb(24, 161, 251);
            tbOperator.ForeColor = Color.White;
            tbModule.BackColor = Color.FromArgb(24, 161, 251);
            tbModule.ForeColor = Color.White;
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
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
                indexOfA = Convert.ToSByte(in_data.IndexOf("A"));
                indexOfB = Convert.ToSByte(in_data.IndexOf("B"));
                indexOfC = Convert.ToSByte(in_data.IndexOf("C"));
                indexOfD = Convert.ToSByte(in_data.IndexOf("D"));
                indexOfE = Convert.ToSByte(in_data.IndexOf("E"));
                indexOfF = Convert.ToSByte(in_data.IndexOf("F"));
                indexOfG = Convert.ToSByte(in_data.IndexOf("G"));
                indexOfH = Convert.ToSByte(in_data.IndexOf("H"));
                indexOfI = Convert.ToSByte(in_data.IndexOf("I"));
                indexOfJ = Convert.ToSByte(in_data.IndexOf("J"));
                indexOfK = Convert.ToSByte(in_data.IndexOf("K"));
                indexOfL = Convert.ToSByte(in_data.IndexOf("L"));
                indexOfM = Convert.ToSByte(in_data.IndexOf("M"));
                indexOfN = Convert.ToSByte(in_data.IndexOf("N"));
                indexOfO = Convert.ToSByte(in_data.IndexOf("O"));
                indexOfP = Convert.ToSByte(in_data.IndexOf("P"));
                indexOfQ = Convert.ToSByte(in_data.IndexOf("Q"));

                //pembacaan nilai
                Temperature = in_data.Substring(0, indexOfA);
                Humidity = in_data.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                V1 = in_data.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                V2 = in_data.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                V3 = in_data.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                V4 = in_data.Substring(indexOfE + 1, (indexOfF - indexOfE) - 1);
                V5 = in_data.Substring(indexOfF + 1, (indexOfG - indexOfF) - 1);
                V6 = in_data.Substring(indexOfG + 1, (indexOfH - indexOfG) - 1);
                V7 = in_data.Substring(indexOfH + 1, (indexOfI - indexOfH) - 1);
                V8 = in_data.Substring(indexOfI + 1, (indexOfJ - indexOfI) - 1);
                V9 = in_data.Substring(indexOfJ + 1, (indexOfK - indexOfJ) - 1);
                VRef1 = in_data.Substring(indexOfK + 1, (indexOfL - indexOfK) - 1);
                VRef2 = in_data.Substring(indexOfL + 1, (indexOfM - indexOfL) - 1);
                VOut1 = in_data.Substring(indexOfM + 1, (indexOfN - indexOfM) - 1);
                VOut2 = in_data.Substring(indexOfN + 1, (indexOfO - indexOfN) - 1);
                VOut3 = in_data.Substring(indexOfO + 1, (indexOfP - indexOfO) - 1);
                VRef3 = in_data.Substring(indexOfP + 1, (indexOfQ - indexOfP) - 1);
                displayValue();
                processInputData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void displayValue()
        {
            //Display text
            tbDate.Text = DateTime.Now.ToString("G");
            tbTemperature.Text = ": " + Temperature + " °C";
            tbHumidity.Text = ": " + Humidity + " %";
            valV1.Text = V1;
            string time = DateTime.Now.ToString("HH" + ':' + "mm" + ':' + "ss");
            rtbSerialData.Invoke((MethodInvoker)delegate { rtbSerialData.AppendText(time + "," + Temperature + "," + Humidity + "," + V1 + "," + V2 + "," + V3 + "," + V4 + "," + V5 + "," + V6 + "," + V7 + "," + V8 + "," + V9 + "," + VRef1 + "," + VRef2 + "," + VOut1 + "," + VOut2 + "," + VOut3 + "\r"); });
        }

        private void processInputData()
        {
            double error;
            bool resulterror = double.TryParse(V1, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out error);
            double dataV1;//V1
            bool resultV1 = double.TryParse(V1, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV1);
            if (resultV1 && 12-error <= dataV1)
            {
                resV1.BackColor = Color.Green;
                resV1.Text = "OK";
            }
            else //if (resultV1 && cbV1.Text == "NO")
            {
            }


            /*double dataV2;//V2
            bool resultV2 = double.TryParse(V2, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV2);
            if (resultV2 && cekV2.Checked == true)
            {
            }
            else //if (resultV2 && cbV2.Text == "NO")
            {
            }

            double dataV3;//V3
            bool resultV3 = double.TryParse(V3, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV3);
            if (resultV3 && cekV3.Checked == true)
            {
            }
            else //if (resultV3 && cbV3.Text == "NO")
            {
            }

            double dataV4;//V4
            bool resultV4 = double.TryParse(V4, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV4);
            if (resultV4 && cekV4.Checked == true)
            {
            }
            else //if (resultV4 && cbV4.Text == "NO")
            {
            }

            double dataV5;//V5
            bool resultV5 = double.TryParse(V5, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV5);
            if (resultV5 && cekV5.Checked == true)
            {
            }
            else //if (resultV5 && cbV5.Text == "NO")
            {
            }

            double dataV6;//V6
            bool resultV6 = double.TryParse(V6, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV6);
            if (resultV6 && cekV6.Checked == true)
            {
            }
            else //if (resultV6 && cbV6.Text == "NO")
            {
            }

            double dataV7;//V7
            bool resultV7 = double.TryParse(V7, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV7);
            if (resultV7 && cekV7.Checked == true)
            {
            }
            else //if (resultV7 && cbV7.Text == "NO")
            {
            }

            double dataV8;//V8
            bool resultV8 = double.TryParse(V8, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV8);
            if (resultV8 && cekV8.Checked == true)
            {
            }
            else //if (resultV8 && cbV8.Text == "NO")
            {
            }

            double dataV9;//V9
            bool resultV9 = double.TryParse(V9, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataV9);
            if (resultV9 && cekV9.Checked == true)
            {
            }
            else //if (resultV9 && cbV9.Text == "NO")
            {
            }

            double dataVRef1;//VRef1
            bool resultVRef1 = double.TryParse(VRef1, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataVRef1);
            if (resultVRef1 && cekVRef1.Checked == true)
            {
            }
            else //if (resultVRef1 && cbVRef1.Text == "NO")
            {
            }

            double dataVRef2;//VRef2
            bool resultVRef2 = double.TryParse(VRef2, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataVRef2);
            if (resultVRef2 && cekVRef2.Checked == true)
            {
            }
            else //if (resultVRef2 && cbVRef2.Text == "NO")
            {
            }

            double dataVOut1;//VOut1
            bool resultVOut1 = double.TryParse(VOut1, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataVOut1);
            if (resultVOut1 && cekVOut1.Checked == true)
            {
            }
            else //if (resultVOut1 && cbVOut1.Text == "NO")
            {
            }

            double dataVOut2;//VOut2
            bool resultVOut2 = double.TryParse(VOut2, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataVOut2);
            if (resultVOut2 && cekVOut2.Checked == true)
            {
            }
            else //if (resultVOut2 && cbVOut2.Text == "NO")
            {
            }

            double dataVOut3;//VOut3
            bool resultVOut3 = double.TryParse(VOut3, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out dataVOut3);
            if (resultVOut3 && cekVOut3.Checked == true)
            {
            }
            else //if (resultVOut3 && cbVOut3.Text == "NO")
            {
            }*/
        }
    }
}
