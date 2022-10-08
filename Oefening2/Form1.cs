namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_sound_Click(object sender, EventArgs e)
        {
            if (cb_koe.Checked)
            {
                Koe koe = new Koe(200);
                MessageBox.Show(koe.makeSound());
            }
            if (cb_slang.Checked)
            {
                Slang slang = new Slang(15);
                MessageBox.Show(slang.makeSound());
            }
            if (cb_varken.Checked)
            {
            Varken varken = new Varken(150);
                MessageBox.Show(varken.makeSound());
            }
        }
    }
}