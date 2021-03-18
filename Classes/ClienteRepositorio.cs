using CadastroLivro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro.Classes
{
    public class ClienteRepositorio : ICliente<Cliente>
    {
        private List<Cliente> listaCliente = new List<Cliente>();
        public void Insere(Cliente objeto)
        {
            listaCliente.Add(objeto);
        }

        public List<Cliente> Lista()
        {
            return listaCliente;
        }

        public int ProximoId()
        {
            return listaCliente.Count;
        }

        public Cliente RetornaPorID(int id)
        {
            return listaCliente[id];
        }
    }
}
