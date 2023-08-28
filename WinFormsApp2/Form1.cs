namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txt1.Text);
            int b = int.Parse(this.txt2.Text);
            int c = int.Parse(this.txt3.Text);

            if (a > b && a > c)
            {
                txtMayor.Text = a.ToString();
            }
            if (b > a && b > c)
            {
                txtMayor.Text = b.ToString();
            }
            if (c > b && c > b)
            {
                txtMayor.Text = c.ToString();
            }
        }
    }
}