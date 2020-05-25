using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAtleta
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }

        Atleta obj = novo  Atleta();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtNome.Text;
                obj.DataNascimento = dtNascimento.Value;
                obj.Altura = double.Parse(txtAltura.Text);
                MessageBox.Show("Dados armazenados com sucesso!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimeDados() +
                            "\n\nIdade: " + obj.CalcularIdade().ToString("00") + " Anos");
            lblIdade.Text = obj.CalcularIdade().ToString() + " Anos";
        }

        private void dtNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
