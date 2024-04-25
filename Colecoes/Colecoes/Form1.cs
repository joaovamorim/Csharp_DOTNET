namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Array
            string[] nomes = new string[3];
            nomes[0] = "João";
            nomes[1] = "Victor";
            nomes[2] = "Amorimn";

            // Lista Generica
            List<string> nomes2 = new List<string>();

            nomes2.Add("Paulo");
            nomes2.Add("Emerson");
            nomes2.AddRange(nomes);

            // Remove um elemento da lista
            // if (nomes2.Remove("Paulo"))
            // {
            //     MessageBox.Show("Paulo Removido!");
            // } 
            // else
            // {
            //     MessageBox.Show("Não foi possivel remover Paulo!");    
            // }
            
            // Verifica se contém um elemento na lista
            // if (nomes2.Contains("João"))
            // {
            //     MessageBox.Show("Contém!");
            // }
            // else
            // {
            //     MessageBox.Show("Não Contém!");
            // }

            // Quantos elementos tem na lista
            // MessageBox.Show("Número de elementos: " + nomes2.Count);
            
            // nomes2.Sort();

            // MessageBox.Show("Paulo está no indice: " + nomes2.IndexOf("Paulo"));

            // nomes2.Insert(2, "Vinicius");

            // nomes2.RemoveAt(1);

            // nomes2.Clear();

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
        }
    }
}
