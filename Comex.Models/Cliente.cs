using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Cliente
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public CPF Cpf { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Cliente(string nome, string sobrenome, string cpf, string telefone, string rua, string numero, string complemento, string bairro, string cidade, string estado)
        {
            Quantidade++;
            Id = Quantidade;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Telefone = telefone;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string NomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }

        public string EnderecoCompleto()
        {
            return Rua + " " + Numero + " " + Complemento + " " + Bairro + " " + Cidade + " " + Estado;
        }
    }
}