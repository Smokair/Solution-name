namespace Oefening5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1(object sender, EventArgs e)
        {
            double celsius = 0.0, fahrenheit = 0.0;
            fahrenheit = Convert.ToDouble(textf.Text);
        }
    }
}