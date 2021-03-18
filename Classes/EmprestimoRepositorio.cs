using CadastroLivro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro.Classes
{
    public class EmprestimoRepositorio : IEmprestimo<Emprestimo>
    {
        private List<Emprestimo> listaEmprestimo = new List<Emprestimo>();

        public int ProximoID()
        {
            return listaEmprestimo.Count;
        }

        public void Emprestimo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Emprestimo> Lista()
        {
            return listaEmprestimo;
        }

        public Emprestimo RetornaPorId(int id)
        {
            return listaEmprestimo[id];
        }

        public void Insere(Emprestimo entidade)
        {
            listaEmprestimo.Add(entidade);
        }
    }
}
