using CadastroLivro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro.Classes
{
    public class LivroRepositorio : IRepositorio<Livro>
    {
        private List<Livro> listaLivros = new List<Livro>();
        public void Atualiza(int id, Livro entidade)
        {
            listaLivros[id] = entidade;
        }

        public void Emprestimo(int id)
        {
            listaLivros[id].Emprestimo();
        }

        public bool retornaEmprestimo()
        {
            return this.retornaEmprestimo();
        }


        public void Exclui(int id)
        {
            listaLivros[id].Excluir();
        }

        public void Insere(Livro entidade)
        {
            listaLivros.Add(entidade);
        }

        public List<Livro> Lista()
        {
            return listaLivros;
        }

        public int ProximoID()
        {
            return listaLivros.Count;
        }

        public Livro RetornaPorId(int id)
        {
            return listaLivros[id];
        }
    }
}
