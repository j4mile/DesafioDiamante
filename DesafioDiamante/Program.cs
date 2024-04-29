namespace DesafioDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDiamante, metadeDiamante;

            Console.WriteLine("Informe o tamanho do diamante (ímpar): ");
            tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            if(tamanhoDiamante % 2 == 0)
            {
                Console.WriteLine("\nValor inválido! Insira um número ímpar.");
                return;
            }

            metadeDiamante = tamanhoDiamante / 2;

            for(int i = 0; i <= metadeDiamante; i++)
            {
                for (int j = 0; j < metadeDiamante - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            for (int i = metadeDiamante - 1; i >= 0; i--)
            {
                for (int j = 0; j < metadeDiamante - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}