using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace centroAutomotivo
{
    class CadastroDAO
    {
        private MySqlConnection conexao;

        public void cadastro(Cadastro mo)
        {
            string con = ("server = localhost; database = CentroAutomotivo; username = root; password = 1921lnhP; ");
            try
            {
                conexao = new MySqlConnection(con);
                conexao.Open();
                string inserir = "insert into Cadastro(Cliente, Veiculo, Placa, KM, Telefone, Email) values('" + mo.Cliente + "', '" + mo.Veiculo + "', '" + mo.Placa + "', '" + mo.KM + "', '" + mo.Telefone + "', '" + mo.Email + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }
    }
}
