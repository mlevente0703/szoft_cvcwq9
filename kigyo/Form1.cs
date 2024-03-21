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

        int irány_x = 1;
        int irány_y = 0;

        int lépésszám;

        List<Kigyoelem> kígyó=new List<Kigyoelem>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * Kigyoelem.Méret;
            fej_y += irány_y * Kigyoelem.Méret;
            Kigyoelem ke = new Kigyoelem();
            kígyó.Add(ke); 
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


            if (kígyó.Count > hossz)
            {
                Kigyoelem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            ke.Top = fej_y;
            ke.Left = fej_x;

            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;

            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}