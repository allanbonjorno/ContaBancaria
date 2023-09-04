using BancoSantoAndre.Controller;
using BancoSantoAndre.Model;
using System;
using System.Security.Cryptography;

namespace BancoSantoAndre01
{
    public class Program
    {

        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {

            int opcao, agencia, tipo, aniversario;
            string? titular;
            decimal saldo, limite;
            ContaController contas = new();
            ContaCorrente c1 = new ContaCorrente(contas.GerarNumero(), 1, 123, "Allan", 1000000.00M);

            ContaPoupanca cp1 = new ContaPoupanca(contas.GerarNumero(), 310001, 1, "TIKA", 50000, 200);

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                  BANCO SANTO ANDRÉ                  ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Criar Conta                          ");
                Console.WriteLine("            2 - Listar todas as Contas               ");
                Console.WriteLine("            3 - Buscar Conta por Numero              ");
                Console.WriteLine("            4 - Atualizar Dados da Conta             ");
                Console.WriteLine("            5 - Apagar Conta                         ");
                Console.WriteLine("            6 - Sacar                                ");
                Console.WriteLine("            7 - Depositar                            ");
                Console.WriteLine("            8 - Transferir valores entre Contas      ");
                Console.WriteLine("            9 - Sair                                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                Console.ResetColor();


                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 9)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nBanco do Brazil com Z - O seu Futuro começa aqui!");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar Conta\n\n");
                        Console.ResetColor();

                        Console.Write("Digite o número da Agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o nome do Titular: ");
                        titular = Console.ReadLine();
                        titular ??= string.Empty;

                        Console.Write("Digite o saldo da Conta: ");
                        saldo = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            Console.Write("Digite o tipo da Conta: ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o Limite da conta:");
                                    limite = Convert.ToDecimal(Console.ReadLine());
                                    contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, titular, saldo, limite));
                                    
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o aniversário da conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());
                                    contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, titular, saldo, aniversario));

                                    break;
                            }

                            KeyPress();
                            break;


                    case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Listar todas as Contas\n\n");
                                Console.ResetColor();
                                contas.ListarTodas();

                                KeyPress();
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Consultar dados da Conta - por número\n\n");
                                Console.ResetColor();

                                KeyPress();
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Atualizar dados da Conta\n\n");
                                Console.ResetColor();

                                KeyPress();
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Apagar a Conta\n\n");
                                Console.ResetColor();

                                KeyPress();
                                break;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Saque\n\n");
                                Console.ResetColor();

                                KeyPress();
                                break;
                            case 7:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Depósito\n\n");
                                Console.ResetColor();

                                KeyPress();
                                break;
                            case 8:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Transferência entre Contas\n\n");
                                Console.ResetColor();

                                KeyPress();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nOpção Inválida!\n");
                                Console.ResetColor();

                                KeyPress();
                                break;
                            }
                        }
        }

                static void Sobre()
                {
                    Console.WriteLine("\n*********************************************************");
                    Console.WriteLine("Projeto Desenvolvido por: ");
                    Console.WriteLine("Generation Brasil - generation@generation.org");
                    Console.WriteLine("github.com/conteudoGeneration");
                    Console.WriteLine("*********************************************************");

                }

                static void KeyPress()
                {
                    do
                    {
                        Console.Write("\nPressione Enter para Continuar...");
                        consoleKeyInfo = Console.ReadKey();
                    } while (consoleKeyInfo.Key != ConsoleKey.Enter);
                }

            }
        } 
