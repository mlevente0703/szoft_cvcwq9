namespace veletlen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w=ClientRectangle.Width;
            int h=ClientRectangle.Height;
            for (int i = 0; i < 100; i++)
            {
                Button button = new();
                Controls.Add(button);
                Random rand = new Random();
                button.Left= rand.Next(0,w);
                button.Top= rand.Next(0,h);
                button.BackColor = Color.FromArgb(rand.Next(0,255), rand.Next(0,255), rand.Next(0,255));
                button.Width=rand.Next(0,w);
                button.Height = rand.Next(0, h);

            }
        }
    }
}
