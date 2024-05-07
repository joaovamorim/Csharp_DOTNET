using System.Reflection;

namespace ThreadForms
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, string propiedade, object valor);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            while (true)
            {
                lblResultado.Text = DateTime.Now.Second.ToString();
            }
        }

        private void DefinirValorPropiedade(Control controle, string propiedade, object valor)
        {
            if (controle.InvokeRequired)
            {   
                AtualizarControle d = new AtualizarControle(DefinirValorPropiedade);
                controle.Invoke(d, new object[] { controle, propiedade, valor });
            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] props = t.GetProperties(); 

                foreach (PropertyInfo p in sprops)
                {
                    if (p.Name.ToUpper() == propiedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }
    }
}
