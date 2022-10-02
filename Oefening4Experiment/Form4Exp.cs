namespace Oefening4Experiment
{
    public partial class Form4Exp : Form
    {
        public Form4Exp()
        {
            InitializeComponent();
        }
        
        private void numericUpDown1_ValueChanged(object senders, EventArgs e)
        {
            int stukp = 10;
            string s1 = stukp.ToString();
            ext_gloves.Text = s1;
        }
    }
}