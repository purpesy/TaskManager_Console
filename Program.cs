using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AULA_PROJETO_1;

    class Program
    {
        static void Main(string[] args)
        {

            GerenciadoDeTarefas gerenciador = new GerenciadoDeTarefas();

        while (true)
            {

                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Atualizar tarefa");
                Console.WriteLine("4 - Remover tarefa");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarTarefa(gerenciador);
                    break;

                    case 2:
                        ListarTarefas(gerenciador);
                    break;

                    case 3:
                        EditarTarefa(gerenciador);
                    break;

                    case 4:
                        DeletarTarefa(gerenciador);
                    break;

                    case 5:
                    Console.WriteLine("Saindo...");
                    return;
                    default:
                    Console.WriteLine("opção invalida. Tente novamente");
                    break;
                }
            }



        }
    static void AdicionarTarefa(GerenciadoDeTarefas gerenciador)
    {
        Console.WriteLine("Digite o título da tarefa:");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite a descrição da tarefa:");
        string descricao = Console.ReadLine();

        Console.WriteLine("Digite o prazo (formato: dd/MM/yyyy):");
        DateTime prazo = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite o status da tarefa:");
        string status = Console.ReadLine();

        Tarefa novaTarefa = new Tarefa(titulo, descricao, prazo, status);
        gerenciador.AdicionarTarefa(novaTarefa);
    }

    static void ListarTarefas(GerenciadoDeTarefas gerenciador)
    {
        gerenciador.ListarTarefas();
    }

    static void EditarTarefa(GerenciadoDeTarefas gerenciador)
    {
        Console.WriteLine("Tarefas disponíveis: ");
        gerenciador.ListarTarefas();

        Console.WriteLine("Digite o índice da tarefa que deseja editar: ");
        int indice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o título da tarefa:");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite a nova descrição da tarefa:");
        string descricao = Console.ReadLine();

        Console.WriteLine("Digite o novo prazo (formato: dd/MM/yyyy):");
        DateTime prazo = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite o novo status da tarefa:");
        string status = Console.ReadLine();

        Tarefa novaTarefa = new Tarefa(titulo, descricao, prazo, status);
        gerenciador.EditarTarefa(indice, novaTarefa);

        Console.WriteLine("Tarefa editada com sucesso.");
    }

    static void DeletarTarefa(GerenciadoDeTarefas gerenciador)
    {
        Console.WriteLine("Tarefas disponíveis: ");
        gerenciador.ListarTarefas();

        Console.WriteLine("Digite o índice da tarefa que deseja editar: ");
        int indice = Convert.ToInt32(Console.ReadLine());

        gerenciador.ExcluirTarefa(indice);

        Console.WriteLine("Tarefa excluida com sucesso");

    }

}

