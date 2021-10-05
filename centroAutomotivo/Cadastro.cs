using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centroAutomotivo
{
    class Cadastro
    {
        double km;
        string cliente, veiculo, placa, email, telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public double KM
        {
            get { return km; }
            set { km = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public string Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
