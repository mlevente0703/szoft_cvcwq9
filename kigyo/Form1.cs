namespace kigyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fej_x = 100;
        int fej_y = 100;

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        int l�p�ssz�m;

        List<Kigyoelem> k�gy�=new List<Kigyoelem>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            //Fejn�veszt�s
            fej_x += ir�ny_x * Kigyoelem.M�ret;
            fej_y += ir�ny_y * Kigyoelem.M�ret;
            Kigyoelem ke = new Kigyoelem();
            k�gy�.Add(ke); 
            Controls.Add(ke);

            foreach (object item in Controls)
            {
                if (item is Kigyoelem)
                {
                    Kigyoelem k = (Kigyoelem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }



            int hossz = Kigyoelem.Hossz;


            if (k�gy�.Count > hossz)
            {
                Kigyoelem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            ke.Top = fej_y;
            ke.Left = fej_x;

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;

            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}