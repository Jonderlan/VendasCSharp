using System;

namespace Vendas {
    class Program {
        static void Main(string[] args) {

            Cliente c = new Cliente();
            int opcao;
            do {
                Console.Clear();
                Console.Write("-----------Menu do exercicios-----------\n\n");
                Console.WriteLine("1 - Cadastrar de Cliente\n" +
                                  "2 - Listar de Clientes\n" +
                                  "3 - Cadastrar Vendedor\n" +
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
                        Console.WriteLine("\n-----------CADASTRO DE CLIENTE-----------\n");
                        Console.WriteLine("Informe o nome do cliente");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF do cliente");
                        c.Cpf = Console.ReadLine();

                        foreach (Cliente clienteCadastrado in clientes) {
                            if (clienteCadastrado.Cpf==c.Cpf) {
                                // Não permitir o cadastro

                                Console.WriteLine("Não foi possível cadastrar!");
                            } else {

                                //Permitir o cadastro

                                clientes.Add(c);
                                Console.WriteLine($"Cliente salvo com sucesso");

                            }
                        }

                        
                        break;

                    case 2:
                        Console.WriteLine("\n-----------LISTAR CLIENTES-----------\n");

                        break;

                    case 3:
                        Console.WriteLine("-----------CADASTRAR VENDEDOR-----------\n");

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
