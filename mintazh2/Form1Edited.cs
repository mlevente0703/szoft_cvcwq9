using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintazh2
{
    public partial class Form1Edited : Form
    {
        public Futok EditedFutok;
        public Form1Edited()
        {
            InitializeComponent();
        }

        private void Form1Edited_Load(object sender, EventArgs e)
        {
            futokBindingSource.DataSource = EditedFutok;
        }
    }
}
