namespace BancoSantoAndre
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)


        {
            int opcao = 0;
            string? nome;


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("****************************************");
                Console.WriteLine("                                        ");
                Console.WriteLine("                                        ");
                Console.WriteLine("                  BANCO                 ");
                Console.WriteLine("               SANTO ANDRÉ              ");
                Console.WriteLine("                                        ");
                Console.WriteLine("****************************************");
                Console.WriteLine("                                        ");
                Console.WriteLine("                                        ");
                Console.WriteLine("      1 - Criar Conta                   ");
                Console.WriteLine("      2 - Listar Todas as Contas        ");
                Console.WriteLine("      3 - Buscar Conta por Número       ");
                Console.WriteLine("      4 - Atualizar dados da conta      ");
                Console.WriteLine("      5 - Apagar Conta                  ");
                Console.WriteLine("      6 - Sacar                         ");
                Console.WriteLine("      7 - Depositar                     ");
                Console.WriteLine("      8 - Transferir Valor entre contas ");
                Console.WriteLine("      9 - Sair da Conta                 ");
                Console.WriteLine("                                        ");
                Console.WriteLine("                                        ");
                Console.WriteLine("****************************************");
                Console.WriteLine("                                        ");
                Console.WriteLine("      Entre com a opção desejada        ");

                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 9)
                {
                    
                    Console.WriteLine("Você saiu!");
                    System.Environment.Exit(0);
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Seu nome completo:");
                        nome = Convert.ToString(Console.ReadLine());

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        Console.WriteLine("Gostaria de voltar ao menu");

                        break;
                }








            }
        }
    }
}
