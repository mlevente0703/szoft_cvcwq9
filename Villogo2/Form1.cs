namespace Villogo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button gomb = new();
            Controls.Add(gomb);
            gomb.Left = ClientRectangle.Width / 2-30;
            gomb.Top = ClientRectangle.Height / 2-15;
            gomb.Width = 60;
            gomb.Height = 30;
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Villogo2 gomb2 = new();
                    Controls.Add(gomb2);
                    gomb2.Text = (i * j).ToString();
                    gomb2.Width = 40;
                    gomb2.Height = 40;
                    gomb2.Left = 40 * i;
                    gomb2.Top = 40 * j;
                }
            }
        }
    }
}
