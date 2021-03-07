using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxsabdo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

           // lstlista.Items.Clear();        

            lstlista.Items.Add(txtdato.Text);

            txtdato.Text = " ";
        }

        private void btnrecorrer_Click(object sender, EventArgs e)
        {
            string salida = " ";

            for(int i=0;i<lstlista.Items.Count;i++)
            {
                salida = salida + "\n" + lstlista.Items[i];
                MessageBox.Show(salida);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
