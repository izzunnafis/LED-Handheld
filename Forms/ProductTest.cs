﻿using System;
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
    public partial class ProductTest : Form
    {
        //private DateTime datetime;
        string in_data;
        static sbyte indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI,
            indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP;
        static string Temp, Humid, V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3;

        private void cbLampTypes_TextChanged(object sender, EventArgs e)
        {
            if (cbLampTypes.Text == "V4.0")
            {
                panel4.Show();
                panel5.Show();
                panel6.Hide();
            }
            else
            {
                panel4.Show();
                panel5.Show();
                panel6.Show();
            }
        }

        sbyte[] index_sep = new sbyte[] {indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI,
            indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP};
        string[] voltages = new string[] { V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3 };
        string[] sep_string = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };
        string[] voltage_name = new string[] { "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "VRef1", "VRef2", "VOut1", "VOut2", "VOut3" };
        TextBox[] text_res_V;
        TextBox[] text_V;

        private void ProductTest_Load(object sender, EventArgs e)
        {
            textTanggal.Text = DateTime.Now.ToString("G");
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            serialPort1.Close();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("ddMMyyyyTHHmmss");
            saveFileDialog1.InitialDirectory = @"C:\Users\%USERNAME%\Documents\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.FileName = time + " Data Logger with " + textModuleID.Text + " by " + textOperatorID.Text;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "Text files (*.csv)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (cbLampTypes.Text == "V4.0")
                {
                    string[] contents = new string[15];
                    contents[0] = "Date" + "," + textTanggal.Text;
                    contents[1] = "Module ID" + "," + textModuleID.Text;
                    contents[2] = "Operator ID" + "," + textOperatorID.Text;
                    contents[3] = "Lamp Type" + "," + cbLampTypes.Text;
                    contents[4] = "Temperature" + "," + text_Temp.Text;
                    contents[5] = "Humidity" + "," + text_Humid.Text;
                    contents[6] = "" + "," + "Volts" + "," + "Results";
                    for (int i = 0; i < 2; i++)
                        contents[i + 7] = voltage_name[i] + "," + text_V[i].Text + "," + text_res_V[i].Text;
                    for (int i = 0; i < 5; i++)
                        contents[i + 9] = voltage_name[i+9] + "," + text_V[i+9].Text + "," + text_res_V[i+9].Text;
                    //contents[7] = "V1" + "," + text_V1.Text + "," + text_ResultV1.Text;
                    //contents[8] = "V2" + "," + text_V2.Text + "," + text_ResultV2.Text;
                    //contents[9] = "VRef1" + "," + text_VRef1.Text + "," + text_ResultVRef1.Text;
                    //contents[10] = "VRef2" + "," + text_VRef2.Text + "," + text_ResultVRef2.Text;
                    //contents[11] = "VOut1" + "," + text_VOut1.Text + "," + text_ResultVOut1.Text;
                    //contents[12] = "VOut2" + "," + text_VOut2.Text + "," + text_ResultVOut2.Text;
                    //contents[13] = "VOut3" + "," + text_VOut3.Text + "," + text_ResultVOut3.Text;
                    contents[14] = "Test Result" + "," + text_TestResult.Text;
                    string location = saveFileDialog1.FileName;
                    System.IO.File.WriteAllLines(location, contents);
                }
                else
                {
                    string[] contents = new string[22];
                    contents[0] = "Date" + "," + textTanggal.Text;
                    contents[1] = "Module ID" + "," + textModuleID.Text;
                    contents[2] = "Operator ID" + "," + textOperatorID.Text;
                    contents[3] = "Lamp Type" + "," + cbLampTypes.Text;
                    contents[4] = "Temperature" + "," + text_Temp.Text;
                    contents[5] = "Humidity" + "," + text_Humid.Text;
                    contents[6] = "" + "," + "Volts" + "," + "Results";
                    for (int i = 0; i < 14; i++)
                        contents[i + 7] = voltage_name[i] + "," + text_V[i].Text + "," + text_res_V[i].Text;
                    contents[21] = "Test Result" + "," + text_TestResult.Text;
                    string location = saveFileDialog1.FileName;
                    System.IO.File.WriteAllLines(location, contents);
                }
                //string[] contents = new string[22];
                //contents[0] = "Date" + "," + textTanggal.Text;
                //contents[1] = "Module ID" + "," + textModuleID.Text;
                //contents[2] = "Operator ID" + "," + textOperatorID.Text;
                //contents[3] = "Lamp Type" + "," + cbLampTypes.Text;
                //contents[4] = "Temperature" + "," + text_Temp.Text; 
                //contents[5] = "Humidity" + "," + text_Humid.Text;
                //contents[6] = "" + "," + "Volts" +  "," + "Results";
                //for (int i = 0; i < 14; i++)
                //    contents[i + 7] = voltage_name[i] + "," + text_V[i].Text + "," + text_res_V[i].Text;
                ////contents[6] = "V1" + "," + text_V1.Text + "," + text_ResultV1.Text;
                ////contents[7] = "V2" + "," + text_V2.Text + "," + text_ResultV2.Text;
                ////contents[8] = "V3" + "," + text_V3.Text + "," + text_ResultV3.Text;
                ////contents[9] = "V4" + "," + text_V4.Text + "," + text_ResultV4.Text;
                ////contents[10] = "V5" + "," + text_V5.Text + "," + text_ResultV5.Text;
                ////contents[11] = "V6" + "," + text_V6.Text + "," + text_ResultV6.Text;
                ////contents[12] = "V7" + "," + text_V7.Text + "," + text_ResultV7.Text;
                ////contents[13] = "V8" + "," + text_V8.Text + "," + text_ResultV8.Text;
                ////contents[14] = "V9" + "," + text_V9.Text + "," + text_ResultV9.Text;
                ////contents[15] = "VRef1" + "," + text_VRef1.Text + "," + text_ResultVRef1.Text;
                ////contents[16] = "VRef2" + "," + text_VRef2.Text + "," + text_ResultVRef2.Text;
                ////contents[17] = "VOut1" + "," + text_VOut1.Text + "," + text_ResultVOut1.Text;
                ////contents[18] = "VOut2" + "," + text_VOut2.Text + "," + text_ResultVOut2.Text;
                ////contents[19] = "VOut3" + "," + text_VOut3.Text + "," + text_ResultVOut3.Text;
                //contents[21] = "Test Result" + "," + text_TestResult.Text;
                //string location = saveFileDialog1.FileName;
                ////string datasave = DateTime.Now.ToString("dd/MM/yyyy") + "\r" + textModuleID.Text + "\r" + textOperatorID.Text + "\r";
                //System.IO.File.WriteAllLines(location, contents);
                ////MessageBox.Show("Data has been saved");
            }
        }

        
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                btnStart.Enabled = false;
                btnStop.Enabled = true;

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
        private void ProcessOkNok()
        {
            double error_V;
            bool error_res = double.TryParse("0.2", NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out error_V);
            double downBoundV = 12 - error_V, upBoundV = 12 + error_V;
            double downBoundVRef1 = 6.5 - error_V, upBoundVRef1 = 6.5 + error_V;
            double downBoundVRef2 = 5.5 - error_V, upBoundVRef2 = 5.5 + error_V;
            double downBoundVOut = 8 - error_V, upBoundVOut = 8 + error_V;
            for (int i = 0; i < 9; i++)
            {
                double data_V;
                bool result_V = double.TryParse(voltages[i], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_V);
                if (result_V)
                {
                    if (data_V >= downBoundV && data_V <= upBoundV)
                    {
                        text_res_V[i].Text = "OK";
                        text_res_V[i].BackColor = Color.Green;
                    }
                    else
                    {
                        text_res_V[i].Text = "NOK";
                        text_res_V[i].BackColor = Color.Red;
                    }
                }
            }
            double data_V9;//VRef1
            bool result_V9 = double.TryParse(voltages[9], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_V9);
            if (result_V9)
            {
                if (data_V9 >= downBoundVRef1 && data_V9 <= upBoundVRef1)
                {
                    text_res_V[9].Text = "OK";
                    text_res_V[9].BackColor = Color.Green;
                }
                else
                {
                    text_res_V[9].Text = "NOK";
                    text_res_V[9].BackColor = Color.Red;
                }
            }
            double data_VRef2;//VRef2
            bool result_VRef2 = double.TryParse(voltages[10], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_VRef2);
            if (result_VRef2)
            {
                if (data_VRef2 >= downBoundVRef2 && data_VRef2 <= upBoundVRef2)
                {
                    text_res_V[10].Text = "OK";
                    text_res_V[10].BackColor = Color.Green;
                }
                else
                {
                    text_res_V[10].Text = "NOK";
                    text_res_V[10].BackColor = Color.Red;
                }
            }
            for (int i = 11; i < 14; i++)
            {
                double data_V;
                bool result_V = double.TryParse(voltages[i], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out data_V);
                if (result_V)
                {
                    if (data_V >= downBoundVOut && data_V <= upBoundVOut)
                    {
                        text_res_V[i].Text = "OK";
                        text_res_V[i].BackColor = Color.Green;
                    }
                    else
                    {
                        text_res_V[i].Text = "NOK";
                        text_res_V[i].BackColor = Color.Red;
                    }
                }
            }
            //Final Result
            text_TestResult.Text = "Success";
            text_TestResult.BackColor = Color.Green;

            for (int i = 0; i < 14; i++)
                if (text_res_V[i].Text == "NOK")
                {
                    text_TestResult.Text = "Failed";
                    text_TestResult.BackColor = Color.Red;
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
                Temp = in_data.Substring(0, index_sep[0]);
                Humid = in_data.Substring(index_sep[0] + 1, (index_sep[2] - index_sep[1]) - 1);
                for (int i = 0; i < 14; i++)
                    voltages[i] = in_data.Substring(index_sep[i + 1] + 1, (index_sep[i + 2] - index_sep[i + 1]) - 1);

                //Display di textbox
                text_Temp.Text = Temp + "°C";
                text_Humid.Text = Humid +"%";
                for (int i = 0; i < 14; i++)
                    text_V[i].Text = voltages[i];

                //NOK or OK
                ProcessOkNok();
                //for(int i=0; i<9; i++)
                //{
                //    float volt_val = float.Parse(voltages[i]);
                //    if(volt_val >= 11.8 && volt_val <=12.2)
                //    {
                //        text_res_V[i].Text = "OK";
                //        text_res_V[i].BackColor = Color.Green;
                //    }
                //    else
                //    {
                //        text_res_V[i].Text = "NOK";
                //        text_res_V[i].BackColor = Color.Red;
                //    }
                //}
                ////for (int i = 9; i < 11; i++)
                ////{
                ////    float volt_val = float.Parse(voltages[i]);
                ////    if (volt_val >= 6.3 && volt_val <= 6.7)
                ////    {
                ////        text_res_V[i].Text = "OK";
                ////        text_res_V[i].BackColor = Color.Green;
                ////    }
                ////    else
                ////    {
                ////        text_res_V[i].Text = "NOK";
                ////        text_res_V[i].BackColor = Color.Red;
                ////    }
                ////}
                //float volt_valref1 = float.Parse(voltages[9]);
                //if (volt_valref1 >= 6.3 && volt_valref1 <= 6.7)
                //{
                //    text_res_V[9].Text = "OK";
                //    text_res_V[9].BackColor = Color.Green;
                //}
                //else
                //{
                //    text_res_V[9].Text = "NOK";
                //    text_res_V[9].BackColor = Color.Red;
                //}
                //float volt_valref2 = float.Parse(voltages[10]);
                //if (volt_valref2 >= 5.3 && volt_valref2 <= 5.7)
                //{
                //    text_res_V[10].Text = "OK";
                //    text_res_V[10].BackColor = Color.Green;
                //}
                //else
                //{
                //    text_res_V[10].Text = "NOK";
                //    text_res_V[10].BackColor = Color.Red;
                //}
                //for (int i = 11; i < 14; i++)
                //{
                //    float volt_val = float.Parse(voltages[i]);
                //    if (volt_val >= 7.8 && volt_val <= 8.2)
                //    {
                //        text_res_V[i].Text = "OK";
                //        text_res_V[i].BackColor = Color.Green;
                //    }
                //    else
                //    {
                //        text_res_V[i].Text = "NOK";
                //        text_res_V[i].BackColor = Color.Red;
                //    }
                //}
                ////Hasil results
                //text_TestResult.Text = "Success";
                //text_TestResult.BackColor = Color.Green;

                //for (int i=0; i<14; i++)
                //    if(text_res_V[i].Text=="NOK")
                //    {
                //        text_TestResult.Text = "Failed";
                //        text_TestResult.BackColor = Color.Red;
                //    }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string[] portlists = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(portlists);
        }
        public ProductTest()
        {
            InitializeComponent();
            text_res_V = new TextBox[] { text_ResultV1, text_ResultV2, text_ResultV3, text_ResultV4, text_ResultV5, text_ResultV6, text_ResultV7, text_ResultV8, text_ResultV9, text_ResultVRef1, text_ResultVRef2, text_ResultVOut1, text_ResultVOut2, text_ResultVOut3 };
            text_V = new TextBox[] { text_V1, text_V2, text_V3, text_V4, text_V5, text_V6, text_V7, text_V8, text_V9, text_VRef1, text_VRef2, text_VOut1, text_VOut2, text_VOut3 };
        }

    }
}
