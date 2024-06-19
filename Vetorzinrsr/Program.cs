namespace Vetorzinrsr
{
    internal class Program
    {
        static void PrintMatrix(int[,] tela) {
            Console.WriteLine("    1   2   3   4 ");

            //Impressão
            for (int j = 0; j < 4; j++)
            {

                Console.Write("   ---------------\n");
                Console.Write("{0} | ", j + 1);
                for (int k = 0; k < 4; k++)
                {
                    Console.Write("{0} | ", tela[j, k]);
                }
                Console.WriteLine();
            }
            Console.Write("   ---------------\n");

        }
        static void Main(string[] args)
        {
            int[,] tela = new int[4, 4];
            int[,] jogo = new int[4, 4];
            int acertos = 0;
            int parar;
            Player p1 =new Player ("Julin");
            Player p2 = null;

            Console.WriteLine(p1._name);
            Console.WriteLine(p2._name);
            Environment.Exit(0);

            Random gerador = new Random();
            DateTime inicio = DateTime.Now;
            int lin, col;

            //Vamos gerar os pares de números e adicionar
            //na matriz jogo
            for (int i = 1; i <= 8; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    do
                    {
                        lin = gerador.Next(0, 4);
                        col = gerador.Next(0, 4);
                    } while (jogo[lin, col] != 0);

                    jogo[lin, col] = i;
                }
            }

            do
            {
               Program.PrintMatrix(tela);

                int lin1, col1;
                Console.WriteLine("Entre com a linha [1, 4]");
                lin1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com a coluna [1, 4]");
                col1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite 0 caso queira encerrar, ou qualquer outro número para continuar");
                int parar = int.Parse(Console.ReadLine());
                if (parar == 0)
                {
                    break;
                }


                lin1--; //diminuir, pois o usuário não sabe
                col1--; //que existe linha e coluna zero
                        //Atribuir o valor da matriz jogo na tela
                tela[lin1, col1] = jogo[lin1, col1];


               Program.PrintMatrix(tela);

                int lin2, col2;
                Console.WriteLine("Entre com a linha [1, 4]");
                lin2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com a coluna [1, 4]");
                col2 = int.Parse(Console.ReadLine());

                lin2--; //diminuir, pois o usuário não sabe
                col2--; //que existe linha e coluna zero
                        //Atribuir o valor da matriz jogo na tela
                tela[lin2, col2] = jogo[lin2, col2];

                Console.WriteLine("    1   2   3   4 ");

                Program.PrintMatrix(tela);

                if (tela[lin1, col1] == tela[lin2, col2])
                {
                    acertos++;
                }
                else //Caso não tenha acertado o par
                {
                    tela[lin1, col1] = 0;
                    tela[lin2, col2] = 0;
                }

            } while (acertos < 8);
        }
    }
}

