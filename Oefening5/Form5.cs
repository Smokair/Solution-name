namespace Oefening5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void ftoc_Click(object sender, EventArgs e)
        {
            double celsius = 0.0, fahrenheit = 0.0;
            fahrenheit = Convert.ToDouble(textF.Text);
            celsius = (5.0 / 9) * (fahrenheit - 32);
            textC.Text = celsius.ToString();
        }

        private void ctof_Click(object sender, EventArgs e)
        {
            double celsius = 0.0, fahrenheit = 0.0;
            celsius = Convert.ToDouble(textC.Text);
            fahrenheit = celsius * 9 / 5 + 32;
            textF.Text = fahrenheit.ToString();
        }
    }
}