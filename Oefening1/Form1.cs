namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
             DialogResult d;
            d = MessageBox.Show("Hallo & Welkom " + Environment.UserName + ", het is " + DateTime.Now.ToShortTimeString() + "u op " + DateTime.Now.ToShortDateString());
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}
    }
}