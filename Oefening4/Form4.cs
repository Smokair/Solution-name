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
            int gloves_price = 10;
            int boots_price = 30;
            int hat_price = 6;
            int skis_price = 700;
            
            if(numericUpDown2_ValueChanged != null)
            {
                for(int i = 0; i < 4; i++)
                {
                    int ext_gloves = numericUpDown1 * gloves_price;
                }
            }

        }
    }
}