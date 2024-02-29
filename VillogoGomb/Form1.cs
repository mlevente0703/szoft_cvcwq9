namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new();
            Controls.Add(button);
            button.Left = ClientRectangle.Width / 2 - button.Width / 2;
            button.Top = ClientRectangle.Height / 2 - button.Height / 2;
            for (int i = 0; i <20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    VillogoGomb vgomb = new();
                    Controls.Add(vgomb);
                    vgomb.Width = 40;
                    vgomb.Height = 40;
                    vgomb.Left = i * 40;
                    vgomb.Top = j * 40;
                }
                
            }
        }
    }
}