namespace haromszog
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
                for (int j = 0; j < i + 1; j++)
                {
                    Button b = new();

                    b.Height = 40;
                    b.Width = 40;
                    b.Left = 40 * j;
                    b.Top = 40 * i;

                    this.Controls.Add(b);
                }
            }
        }
    }
}
