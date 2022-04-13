using System;

namespace JogoAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Random random = new Random();

                int numeroCerto = random.Next(1, 5);

                int chute = 0;
                int tent = 0;

                Console.WriteLine("Chute um numero entre 1 e 5");

                while (chute != numeroCerto)
                {
                    int input = int.Parse(Console.ReadLine());
                    chute = input;

                    if (chute != numeroCerto)
                    {
                        Console.WriteLine("Voce errou!");
                        if (tent < 2)
                        {
                            Console.WriteLine("Tente Novamente");
                        }
                        else
                        {
                            Console.WriteLine("Tentativas Esgotadas");
                            break;
                        }
                    }
                    tent++;
                }
                if (chute == numeroCerto)
                {
                    Console.WriteLine("Parabens! O numero correto e {0}", numeroCerto);
                }
                else
                {
                    Console.WriteLine("O numero correto e {0}", numeroCerto);
                }

                Console.WriteLine("Deseja jogar novamente? Digite S para continuar ou qualquer tecla para sair");
                string resp = Console.ReadLine().ToUpper();
                if (resp == "S")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }          
            
        }
                    
    }
}
