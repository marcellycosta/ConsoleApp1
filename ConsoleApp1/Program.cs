

using ConsoleApp1;
using System;


namespace BancoFBagarai

{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;

            Menu menu = new Menu();

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1- Correntista");
                Console.WriteLine("2- Conta");
                Console.WriteLine("3- Operações");
                Console.WriteLine("0- Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        menu.OpcaoCorrentista();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Aplicação Encerrada");
                        break;

                }
            }
        }
    }
    public class Menu 
    {
     
        public void OpcaoCorrentista()
        {

            string database = "sqlite.db";
            string conection = $"Data Source={database};Version=3;";
            Correntista correntista = new Correntista();
            

            int opcao = -1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU CORRENTISTA");
                Console.WriteLine("1. Cadastrar novo correntista");
                Console.WriteLine("2. Editar dados");
                Console.WriteLine("3. Excluir correntista");
                Console.WriteLine("4. Visualizar correntista");
                Console.WriteLine("0. Retornar");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: correntista.CadastrarCorrentista(conection); break;
                    case 2: correntista.EditarCorrentista(); break;
                    case 3: correntista.ExcluirCorrentista(); break;
                    case 4: correntista.VisualizarCorrentista();break;
                }
            }
        }

      
        public void Inicializar()
        {
            int opcao = -1;

            
            

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1- Correntista");
                Console.WriteLine("2- Conta");
                Console.WriteLine("3- Operações");
                Console.WriteLine("0- Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        OpcaoCorrentista();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Aplicação Encerrada");
                        break;

                }
            }

        }

        
        
    }
}

