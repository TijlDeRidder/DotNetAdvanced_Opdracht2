namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_Dollar_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified){
                if (tb_Dollar.Text.Length > 0)
                {
                    tb_Euro.Text = (Double.Parse(tb_Dollar.Text) * 1.01805).ToString();
                    tb_Pound.Text = (Double.Parse(tb_Dollar.Text) * 0.88345).ToString();
                    tb_Yen.Text = (Double.Parse(tb_Dollar.Text) * 145.365).ToString();
                    tb_Franken.Text = (Double.Parse(tb_Dollar.Text) * 0.99193).ToString();
                    tb_rupees.Text = (Double.Parse(tb_Dollar.Text) * 82.8246).ToString();
                }
            }
        }

        private void tb_Pound_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tb_Pound.Text.Length > 0)
                {
                    tb_Dollar.Text = (Double.Parse(tb_Pound.Text) * 1.10865).ToString();
                }
            }
        }

        private void tb_Euro_TextChanged(object sender, EventArgs e)
        {
            if(((TextBox)sender).Modified){
                if(tb_Euro.Text.Length > 0)
                {
                    tb_Dollar.Text = (Double.Parse(tb_Euro.Text) * 0.9745).ToString();
                }
            }
        }

        private void tb_Yen_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tb_Yen.Text.Length > 0)
                {
                    tb_Dollar.Text = (Double.Parse(tb_Yen.Text) * 0.006879).ToString();
                }
            }
        }

        private void tb_rupees_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tb_rupees.Text.Length > 0)
                {
                    tb_Dollar.Text = (Double.Parse(tb_rupees.Text) * 0.012074).ToString();
                }
            }
        }

        private void tb_Franken_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tb_Franken.Text.Length > 0)
                {
                    tb_Dollar.Text = (Double.Parse(tb_Franken.Text) * 1.005252).ToString();
                }
            }
        }
    }
}

