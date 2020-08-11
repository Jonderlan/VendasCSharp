using System;

namespace Vendas {
    class Program {
        static void Main(string[] args) {

            int opcao;
            do {
                Console.Clear();
                Console.Write("-----------Menu do exercicios-----------\n\n");
                Console.WriteLine("1 - Cadastrar de Cliente\n" +
                                  "2 - Listar de Clientes\n" +
                                  "3 - Cadastrar de Vendedor\n" +
                                  "4 - Listar de Vendedores\n" +
                                  "5 - Cadastrar de Produto\n" +
                                  "6 - Listar de Produtos\n" +
                                  "7 - Registrar Venda\n" +
                                  "8 - Listar Vendas\n" +
                                  "9 - Listar Vendas por Cliente\n" +
                                  "0 - Sair\n");

                Console.Write("Informe o exercicio a se executado: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcao) {

                    case 1:
                        Console.WriteLine("\n-----------Entrou lição 01\n");

                        break;

                    case 2:
                        Console.WriteLine("\n-----------Entrou lição 02\n");

                        break;

                    case 3:
                        Console.WriteLine("-----------Entrou lição 03\n");

                        break;

                    case 4:
                        Console.WriteLine("-----------Entrou lição 04\n");

                        break;

                    case 5:
                        Console.WriteLine("-----------Entrou lição 05\n");

                        break;

                    case 6:
                        Console.WriteLine("-----------Entrou lição 06\n");

                        break;

                    case 7:
                        Console.WriteLine("-----------Entrou lição 07\n");

                        break;

                    case 8:
                        Console.WriteLine("-----------Entrou lição 08\n");

                        break;

                    case 9:
                        Console.WriteLine("-----------Entrou lição 09\n");

                        break;

                    case 0:
                        Console.WriteLine("-----------Saindo ...\n");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("\nPrecione uma tecla para continuar");
                Console.ReadKey();
            } while (opcao != 0);


        }
    }
}
