using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_PROJETO_1
{
    public class Tarefa
    {
        public string Titulo { get; set;  }
        public string Descricao { get; set; }
        public DateTime Prazo {  get; set; }
        public string Status {  get; set; }

        public Tarefa(string titulo, string descricao, DateTime prazo,  string status)
        {
            Titulo = titulo;
            Descricao = descricao;
            Prazo = prazo;
            Status = status;
        }
        public override string ToString()
        {
            return $"Título: {Titulo}\nDescrição: {Descricao}\nPrazo: {Prazo.ToShortDateString()}\nStatus: {Status}";
        }
    }
}
