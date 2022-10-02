namespace Oefening7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            int n = 0;
            number = Convert.ToInt32(textBox1.Text);

            for(int i = 0; i <= number; i++)
            {
                n = n + i;
            }
            output.Text = n.ToString();
        }
    }
}