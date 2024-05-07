namespace Formulario
{
    public partial class FormSegunda : Form
    {
        public string Mensagem { get; set; }


        public FormSegunda()
        {
            InitializeComponent();
        }

        public FormSegunda(string mensagem)
        {
            InitializeComponent();

            Mensagem = mensagem;
        }

        private void FormSegunda_Load(object sender, EventArgs e)
        {
            txtMensagem.Text = Mensagem;
        }

        private void btnFormPrincipal_Click(object sender, EventArgs e)
        {
            Close();
            Thread thread = new Thread(() => Application.Run(new FormMain()));
            thread.Start();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text == "" || txtMensagem.Text == null)
            {
                Mensagem = null;
            }
            else
            {
                Mensagem = txtMensagem.Text;
            }

            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Mensagem = null;
            Close();
        }
    }
}
