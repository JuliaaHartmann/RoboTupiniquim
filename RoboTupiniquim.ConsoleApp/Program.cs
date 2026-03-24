using System.Reflection;
using System.Reflection.PortableExecutable;

namespace RoboTupiniquim.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("-----Robô Tupiniquim-----");
        Console.WriteLine("-------------------------");

        // Solicitar ao usuário o valor de X (int)
        Console.Write("Digite o valor da posição X: ");
        int valorX = Convert.ToInt32(Console.ReadLine());

        // Solicitar ao usuário o valor de Y (int)
        Console.Write("Digite o valor da posição Y: ");
        int valorY = Convert.ToInt32(Console.ReadLine());

        // Solicitar ao usuário a direção (string)
        Console.Write("Digite a direção: ");
        string? direcao = Console.ReadLine()?.ToUpper();

        //Solicitar ao usuário uma série de instruções (E, D, M) que o robô deve seguir
        Console.WriteLine("Digite a sequência de comandos: ");
        string? comandos = Console.ReadLine()?.ToUpper(); // ['E', 'M', 'E', 'M', 'E', 'M', 'E', 'M', 'M']

        foreach (char comando in comandos)
        {
            //Mudar direção para esquerda
            if (comando == 'E')
            {
                if (direcao == "N")
                    direcao = "O";

                else if (direcao == "O")
                    direcao = "S";

                else if (direcao == "S")
                    direcao = "L";

                else
                    direcao = "N";
            }

            //Mudar direção para D
            if (comando == 'D')
            {
                if (direcao == "N")
                    direcao = "L";

                else if (direcao == "L")
                    direcao = "S";

                else if (direcao == "S")
                    direcao = "O";

                else 
                    direcao = "N";                    
            
            }

            //Mover "objeto"
            if (comando == 'M')
            {
                if (direcao == "N")
                    valorY += 1;

                else if (direcao == "O")
                    valorX -= 1;

                else if (direcao == "S") 
                    valorY -= 1;

                else 
                    valorX += 1;
            }

        }

        Console.WriteLine($"Posição final: {valorX} {valorY} {direcao}");
    }

}
