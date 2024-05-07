namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda formSegunda = new FormSegunda("Bem-Vindo.");
            // formSegunda.Mensagem = "João";

            formSegunda.ShowDialog();

            if (formSegunda.Mensagem != null)
            {
                lblTitulo.Text = formSegunda.Mensagem;
            }

            Show();
        }

        private void btnSegundaFormThread_Click(object sender, EventArgs e)
        {
            Close();
            Thread thread = new Thread(() => Application.Run(new FormSegunda()));
            thread.Start();
        }

        private void mFileNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
        }

        private void mFileAbrir_Click(object sender, EventArgs e)
        {
            FormSegunda formSegunda = new FormSegunda();
            formSegunda.ShowDialog();
            Show();
        }

        private void mFileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelpSobreDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("João Amorim");
        }

        private void mHelpSobreVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0");
        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMenu.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";
            }
            else
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }
        }

        private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblTitulo.Text = mPesquisar.Text;
                mPesquisar.Text = "";                                   
            }
        }
    }
}
