using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro.Interfaces
{
    public interface IEmprestimo<T>
    {
        List<T> Lista();
        void Insere(T entidade);
        void Emprestimo(int id);
        int ProximoID();
        T RetornaPorId(int id);
    }
}
