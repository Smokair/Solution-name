namespace IsItBigger
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int oplossing1 = 12345 * 54321;
            string s1 = $"12345 * 54321 = {oplossing1}";
            label1.Text = s1;

            int oplossing2 = 22222 * 33333;
            string s2 = $"22222 * 33333 = {oplossing2}";
            label2.Text = s2;

            if(oplossing1 < oplossing2){
                string s3 = $"12345 * 54321 < 22222 * 33333";
                label3.Text = s3;
            }

        }
    }
}