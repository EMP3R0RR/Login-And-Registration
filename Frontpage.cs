namespace DreamProperties
{
    public partial class Frontpage : Form
    {
        public Frontpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginpage f1 = new Loginpage();
            f1.Show();
            this.Hide();
        }
    }
}
