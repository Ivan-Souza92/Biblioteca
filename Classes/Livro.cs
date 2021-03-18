using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro
{
    public class Livro : EntidadeBase
    { 
        private string Exemplar { get; set; }
        private Genero Genero { get; set; }
        private string Autor { get; set; }
        private int Edicao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        private bool emprestimo { get; set; }

        public Livro()
        {
                
        }

        public Livro(int id, string exemplar ,Genero genero , string autor , int edicao, int ano)
        {
            this.Id = id ;
            this.Exemplar = exemplar;
            this.Genero = genero;
            this.Autor = autor;
            this.Edicao = edicao;
            this.Ano = ano;
            this.Excluido = false;
            this.emprestimo = false;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Emprestimo()
        {
            this.emprestimo = true;
        }

        public bool retornaEmprestimo()
        {
            return this.emprestimo ;
        }

        public string ExemplarName()
        {
            return this.Exemplar;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Exemplar: " + this.Exemplar + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Edicao: " + this.Edicao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            retorno += "\nEmprestado: " + this.emprestimo;

            return retorno;
        }
    }
}
