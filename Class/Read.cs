﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;

namespace LED_Handheld_Project.Class
{
    public class Read
    {
        public int nLines { get; private set; }
        public int nColumns { get; private set; }
        public string[] header { get; private set; }
        public float[,] data { get; private set; }
        public string fileName { get; set; }
        public string[] section { get; private set; }

        public Read(string file)
        {
            string[] pieces;

            fileName = Path.GetFileName(file);
            string[] lines = File.ReadAllLines(file); // read all lines
            if (lines == null || lines.Length < 2) return; //no data in file
            header = lines[0].Split(','); //first line is header
            nLines = lines.Length - 1; //first line is header
            nColumns = header.Length;

            //read the numerical data and section name from the file
            data = new float[nLines, nColumns - 1]; // *** 1 less than nColumns as last col is sectionName
            section = new string[nLines]; // *** 
            for (int i = 0; i < nLines; i++)
            {
                pieces = lines[i + 1].Split(','); // first line is header
                if (pieces.Length != nColumns) { MessageBox.Show("Invalid data at line " + (i + 2) + " of file " + fileName); return; }
                for (int j = 0; j < nColumns - 1; j++)
                {
                    float.TryParse(pieces[j], out data[i, j]); //data[i, j] = float.Parse(pieces[j]);
                }
                section[i] = pieces[nColumns - 1]; //last item is section
            }
        }
    }
}
