using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivro
{
    public class Emprestimo : EntidadeEmprestimo
    {
        private int id_Cliente { get; set; }
        private int id_Livro { get; set; }
        private int dia { get; set; }
        private int mes { get; set; }
        private int ano { get; set; }
        private int hora { get; set; }
        private int minuto { get; set; }
        private int segundos { get; set; }

        private DateTime data ;


        public Emprestimo(int id,int idCliente , int idLivro , int dia , int mes , int ano,int hour , int minutes , int seconds)
        {
            this.Id = id;
            this.id_Cliente = idCliente;
            this.id_Livro = idLivro ;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
            this.hora = hour;
            this.minuto = minutes;
            this.segundos = seconds;
            //this.data = new DateTime(ano, mes, dia, hora, minuto, segundos);
            this.data = new DateTime(this.ano, this.mes, this.dia, this.hora, this.minuto, this.segundos);

        }


        public override string ToString()
        {
            string retorno = "";
            retorno += "Id do cliente: " + this.id_Cliente + Environment.NewLine;
            retorno += "Id do livro: " + this.id_Livro + Environment.NewLine;
            retorno += "Data do empréstimo: " + this.data + Environment.NewLine;

            return retorno;
        }
    }

}
