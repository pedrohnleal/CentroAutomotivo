using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace centroAutomotivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cadastro mo = new Cadastro();
            CadastroDAO ac = new CadastroDAO();
            mo.Cliente = txtCliente.Text;
            mo.Veiculo = txtVeiculo.Text;
            mo.Placa = txtPlaca.Text;
            mo.KM = Convert.ToDouble(txtKM.Text);
            mo.Telefone = mskTelefone.Text;
            mo.Email = txtEmail.Text;
            ac.cadastro(mo);
            txtCliente.Text = "";
            txtVeiculo.Text = "";
            txtPlaca.Text = "";
            txtKM.Text = "";
            mskTelefone.Text = "";
            txtEmail.Text = "";
        }
    }
}
