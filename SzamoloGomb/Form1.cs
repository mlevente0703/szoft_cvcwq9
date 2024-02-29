namespace SzamoloGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    SzamoloGomb gomb = new();
                    Controls.Add(gomb);
                    gomb.Left = i * 30;
                    gomb.Top = j * 30;
                }
            }

        }
    }
}