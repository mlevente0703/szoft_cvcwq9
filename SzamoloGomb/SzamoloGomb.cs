using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGomb
{
    internal class SzamoloGomb : Button
    {
        int szám = 1;
        public SzamoloGomb() //ctor
        {
            Width = 20;
            Height = 20;
            Click += SzamoloGomb_Click; //+= után tab
            Text = szám.ToString(); // ctrl + k + d formázás
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            szám += 1;
            if (szám > 5)
            {
                szám = 1;
                Text = szám.ToString();
            }
            else
            {
                Text = szám.ToString();
            }

        }
    }
}
