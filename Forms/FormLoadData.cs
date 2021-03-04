using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;
using System.IO.Ports;
using System.Globalization;
using System.IO;

namespace LED_Handheld_Project.Forms
{
    public partial class FormLoadData : Form
    {
        //Fields
        static string Temperature, Humidity, V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3;
        string[] voltages = new string[] { V1, V2, V3, V4, V5, V6, V7, V8, V9, VRef1, VRef2, VOut1, VOut2, VOut3 };
        string[] voltage_name = new string[] { "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "VRef1", "VRef2", "VOut1", "VOut2", "VOut3" };
        CheckBox[] cek_V;
        //Graphics
        static kayChart serialDataChartV1, serialDataChartV2, serialDataChartV3, serialDataChartV4, serialDataChartV5,
    serialDataChartV6, serialDataChartV7, serialDataChartV8, serialDataChartV9,
    serialDataChartVRef1, serialDataChartVRef2,
    serialDataChartVOut1, serialDataChartVOut2, serialDataChartVOut3;

        kayChart[] chart_V = new kayChart[]
        {serialDataChartV1, serialDataChartV2, serialDataChartV3, serialDataChartV4, serialDataChartV5,
            serialDataChartV6, serialDataChartV7, serialDataChartV8, serialDataChartV9,
            serialDataChartVRef1, serialDataChartVRef2,
            serialDataChartVOut1, serialDataChartVOut2, serialDataChartVOut3
        };
        //List<Class.Read> rrlist = new List<Class.Read>();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filename = "";
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\%USERNAME%\Documents\";
            openFileDialog1.Title = "Open Files";
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "Text files (*.csv)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string filename = openFileDialog1.FileName;
                //string[] raw_text = System.IO.File.ReadAllLines(filename);
                string[] datacol = null;
                int x = 0;
                //foreach(string text_line in raw_text)
                //{
                //    datacol = text_line.Split(',');
                //    foreach (string column in datacol)
                //    {
                        
                //    }
                //}
                this.Controls.Add(dataGridView1);
            }
            //DataTable data = new DataTable();
            //data = NewDataTable(filename, ",", true);
        }
        public FormLoadData()
        {
            InitializeComponent();
            cek_V = new CheckBox[] { cbV1, cbV2, cbV3, cbV4, cbV5, cbV6, cbV7, cbV8, cbV9, cbVRef1, cbVRef2, cbVOut1, cbVOut2, cbVOut3 };
        }

        private void FormLoadData_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
