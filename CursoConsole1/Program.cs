using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, operacao;
            String cliente = "", produto = "";
            Console.Clear();
            do
            {
            Console.WriteLine("1- Cliente");
            Console.WriteLine("2- Produto");
            Console.WriteLine("3- Sair");
            opcao = Convert.ToInt32(Console.ReadLine());
           
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("1 - Cadastrar Cliente novo:");
                    Console.WriteLine("2 - Consultar Cliente :");
                    break;
                case 2:
                    Console.WriteLine("1 - Cadastrar Produto novo:");
                    Console.WriteLine("2 - Consultar Produto:");
                    break;
                case 3:
                    Console.WriteLine("Saindo!");
                    break;
                default:
                    Console.WriteLine("Opção Invalida!!");
                    break;
            }
           

                if (opcao.Equals(1))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.WriteLine("Digite o Nome do Cliente");
                        cliente = Console.ReadLine();
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    else if (operacao.Equals(2))
                    {
                        Console.WriteLine("Nome do cliente: " + cliente);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                        
                    }
                }
                if (opcao.Equals(2))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.WriteLine("Digite o Nome do produto");
                        produto = Console.ReadLine();
                        Console.WriteLine("produto cadastrado com sucesso!");
                    }
                    else if (operacao.Equals(2))
                    {
                        Console.WriteLine("Produto: " + produto);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }

            } while (opcao != 3);
            Console.Clear();
        }
    }
}
