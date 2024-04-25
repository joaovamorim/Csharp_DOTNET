namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contais / ToString
            // string texto = "Este tipo de variável é alfanumerica."   
            
            // if (texto.Contains("var"))
            // {
            //     label1.Text = "Contém.";
            // }
            // else
            // {
            //     label1.Text = "Não Contém.";
            // }

            // int num = 5400;
            // bool res = true;

            // label1.Text = res.ToString();
            #endregion

            #region ToUpper / ToLower
            // string nome = "JoÃo";

            // string nomeMA = nome.ToUpper();
            // string nomeMI = nome.ToLower();

            // label1.Text = nomeMI;
            #endregion

            #region IndexOf / LastIndexOf
            // string nome = "João Amorim";

            // // int indice = nome.IndexOf('o', 1);

            // int indice = nome.LastIndexOf("m");
            // label1.Text = "Indice: " + indice;
            #endregion

            #region Insert / Replace
            // string nome = "João Amorim";

            // // string nomeFinal = nome.Insert(5, "Victor ");

            // string nomeFinal = nome.Replace("Amorim", "Roberto");

            // label1.Text = nomeFinal;
            #endregion

            #region Length / Substring
            // string nome = "João Victor Amorim";

            // int tamanho = nome.Length;
            // label1.Text = "O nome " + nome + " Contém " + tamanho + " Letras.";

            // for (int i = 0; i < nome.Length; i++)
            // {
            //     label1.Text += nome[i] + "\n";
            // }

            // string parte = nome.Substring(12, 6);

            // label1.Text = parte;
            #endregion

            #region Split
            // string nomes = "João Paulo Emerson Vinicius Fabio Fernando";

            // char[] separador = { ' ' };

            // string[] resultado = nomes.Split(separador);

            // foreach (string nome in resultado)
            // {
            //     label1.Text += nome + "\n";
            // }
            #endregion

            string nome = "João Victor Amorim";

            nome.StartsWith("F  ");
        }
    }
}
