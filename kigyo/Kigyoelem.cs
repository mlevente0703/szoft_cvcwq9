using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    internal class Kigyoelem:PictureBox
    {
        public static int Méret = 20;
        public static int Hossz = 5;
        public Kigyoelem()
        {
            Width = Kigyoelem.Méret;
            Height = Kigyoelem.Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
