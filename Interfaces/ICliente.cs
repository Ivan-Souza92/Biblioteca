using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro.Interfaces
{
    public interface ICliente<T>
    {
        List<T> Lista();
        T RetornaPorID(int id);
        void Insere(T objeto);
        int ProximoId();
    }
}
