namespace FormMdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            // f.MdiParent = this;

            f.Show();
        }
    }
}
