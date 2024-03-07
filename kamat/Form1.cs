namespace kamat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button()
            {
                Width = 100,
                Height = 30,
                Location = new Point(200, 400),
                Text = "Click"
            };
            this.Controls.Add(button);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double hitelossz = double.Parse(tbHitel.Text);

            List<sor> sorok = new List<sor>();

            for (int i = 0; i < 10; i++)
            {
                sor usor = new sor();
                usor.Hatralek = fugg(i*hitelossz);
                usor.Honap = i;
                sorok.Add(usor);
            }   
            dataGridView1.DataSource = sorok;
            double fugg(double n)
            {
                double eredmeny = 2;
                eredmeny *= n;

                return eredmeny;
            }
        }
    }
}
