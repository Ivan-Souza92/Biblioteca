using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro.Classes
{
    public class Cliente : EntidadeCliente
    {
        private string Nome { get; set; }
        private Sexo Sexo { get; set; }
        private string CPF { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }

        public Cliente(int id , string nome , Sexo sexo , string cpf , string endereco , string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sexo = sexo;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public string RetornaNome()
        {
            return this.Nome;
        }
    }
}
