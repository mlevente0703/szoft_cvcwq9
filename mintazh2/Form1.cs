using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace mintazh2
{
    public partial class Form1 : Form
    {
        BindingList<Futok> futoklist = new BindingList<Futok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            futokBindingSource.DataSource = futoklist;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("TextFile1.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Futok>();
                foreach (var item in tömb)
                {
                    futoklist.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futoklist);
                    sw.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (futokBindingSource.Current is Futok)
            {
                DialogResult res = MessageBox.Show("Biztosan ki akarod törölni?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        futoklist.Remove((Futok)futokBindingSource.Current);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form1Edited ef = new Form1Edited();
            if (futokBindingSource.Current is Futok)
            {
                ef.EditedFutok = (Futok)futokBindingSource.Current;
            }
            ef.Show();
        }

        private void buttonBest_Click(object sender, EventArgs e)
        {
            double best = double.PositiveInfinity;
            int darab = 0;
            double összeg = 0;
            string ki = "";
            foreach (var item in futoklist)
            {
                if (item.Nemzetiseg == "USA")
                {
                    if (item.EredmenyPerc < best)
                    {
                        best = item.EredmenyPerc;
                        ki = item.Nev;
                    }
                    darab++;
                    összeg += item.EredmenyPerc;

                }


            }
            double átlag = összeg / darab;
            MessageBox.Show($"A legjobb idõt {ki} futotta: {best}. Az átlag idõ: {átlag}");

        }
    }
}
