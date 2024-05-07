namespace FormMdi
{
    public partial class Form2 : Form
    {
        public Form2(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(MdiParent);

            f.Show();
        }
    }
}
