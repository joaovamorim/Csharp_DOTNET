namespace ClassesImport;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnMessageBox_Click(object sender, EventArgs e)
    {
        // Imprimir msg
        // MessageBox.Show("Teste!");

        // msg + titulo da msg
        // MessageBox.Show("Mensagem", "Titulo msg");

        // button do MessageBox
        // DialogResult res = MessageBox.Show("Mensagem", "Titulo msg", MessageBoxButtons.OKCancel);

        // if (res == DialogResult.OK)
        // {
        //     lblResultado.Text = "Clicou em ok";
        // }
        // else if (res == DialogResult.Cancel)
        // {
        //     lblResultado.Text = "Clicou em Cancel";
        // }

        //
        // MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
    }

    private void btnAleatorio_Click(object sender, EventArgs e)
    {

    }

    private void btnTimeSpan_Click(object sender, EventArgs e)
    {
        lblResultado.Text = TimeSpan.FromMinutes(60).ToString();
    }
}
