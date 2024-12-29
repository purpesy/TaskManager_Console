using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_PROJETO_1
{
    public class GerenciadoDeTarefas
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas");
                return;
            } 
            
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
                Console.ReadLine();
            }
        }

        public void EditarTarefa(int indice, Tarefa NovaTarefa)
        {
            if (indice >= 0  && indice < tarefas.Count)
            {
                tarefas[indice] = NovaTarefa;
                Console.WriteLine("Tarefa editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Indice invalido");
            }
        }

        public void ExcluirTarefa(int indice)
        {
            if (indice >= 0 && indice < tarefas.Count)
            {
                tarefas.RemoveAt(indice);
                Console.WriteLine("Tarefa excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }
    }
}
