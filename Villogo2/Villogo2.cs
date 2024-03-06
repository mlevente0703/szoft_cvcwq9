using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villogo2
{
    internal class Villogo2 : Button
    {
        public Villogo2()
        {
            MouseEnter += Villogo2_MouseEnter;
            MouseLeave += Villogo2_MouseLeave;
        }

        private void Villogo2_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = default;
        }

        private void Villogo2_MouseEnter(object? sender, EventArgs e)
        {
            BackColor= Color.Fuchsia;
        }
    }
}
