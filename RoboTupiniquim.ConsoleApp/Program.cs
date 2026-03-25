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

        Console.Write("Digite o valor da posição X: ");
        int valorX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor da posição Y: ");
        int valorY = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a direção: ");
        string? direcao = Console.ReadLine()?.ToUpper();

        Console.WriteLine("Digite a sequência de comandos: ");
        string? comandos = Console.ReadLine()?.ToUpper();

        foreach (char comando in comandos)
        {
            if (comando == 'E')
            {
                if (direcao == "N") direcao = "O";
                else if (direcao == "O") direcao = "S";
                else if (direcao == "S") direcao = "L";
                else if (direcao == "L") direcao = "N";
            }

            if (comando == 'D')
            {
                if (direcao == "N") direcao = "L";
                else if (direcao == "L") direcao = "S";
                else if (direcao == "S") direcao = "O";
                else if (direcao == "O") direcao = "N";
            }

            if (comando == 'M')
            {
                if (direcao == "N") valorY++;
                else if (direcao == "O") valorX--;
                else if (direcao == "S") valorY--;
                else if (direcao == "L") valorX++;
            }

        }

        Console.WriteLine($"Posição final: {valorX} {valorY} {direcao}");
    }

}
