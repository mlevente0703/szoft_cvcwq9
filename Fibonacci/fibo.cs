namespace Fibonacci
{
    public partial class fibo : Form
    {
        public fibo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();
            for (int i = 0; i < 20; i++)
            {
                Sor �jsor = new Sor();
                �jsor.Sorsz�m = i;
                �jsor.�rt�k = Fibonacci(i);
                sorok.Add(�jsor);
                Button button = new Button();
                Controls.Add(button);
                button.Text = Fibonacci(i).ToString();
                button.Top = i * 20;
                button.Left = 250;
            }
            dataGridView1.DataSource = sorok;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }


    }
}
