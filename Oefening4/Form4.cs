namespace Oefening4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void id_tax_rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void gloves_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int priceEach = 10;
            string s1 = priceEach.ToString();
            ext_gloves.Text = s1;

            if (numericUpDown1.Equals(2))
            {
                string s2 = priceEach.ToString();
                ext_gloves.Text = s2;
            }

        }

        private void ext_gloves_TextChanged(object sender, EventArgs e)
        {
            //for(int i = 10; i < 100; i++)
            //{
            //    int waarde = 10;
            //    string s1 = waarde.ToString();
            //    ext_gloves.Text = s1;
            //}
        }
    }
}