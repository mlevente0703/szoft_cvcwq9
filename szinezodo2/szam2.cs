using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamolo2
{
    internal class szam2 :Button
    {
        int szam = 1;
        public szam2()
        {
            Click += Szam2_Click;
            Width = 30;
            Height = 30;
            Text = szam.ToString();
        }

        private void Szam2_Click(object? sender, EventArgs e)
        {
            if (szam == 5) 
            {
                szam = 1;
            }
            else
            {
                szam += 1;
            }
            Text = szam.ToString();

        }
    }
}
