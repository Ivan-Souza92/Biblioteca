using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);               
        void Insere(T entidade);
        void Atualiza(int id, T entidade);
        int ProximoID();
        void Exclui(int id);
        void Emprestimo(int id);
    }
}
