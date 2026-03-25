using System.Reflection;
using System.Reflection.PortableExecutable;

namespace RoboTupiniquim.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ExibirCabecalho();

        Console.Write("\nDigite o valor da posição X: ");
        int pX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor da posição Y: ");
        int pY = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a direção: ");
        char dir = Convert.ToChar(Console.ReadLine().ToUpper());

        Robo.Configurar(pX, pY, dir);

        Console.WriteLine("Digite a sequência de comandos: ");
        string? comandos = Console.ReadLine()?.ToUpper();

        Robo.ExecutarComando(comandos!);

        Console.WriteLine($"\nPosição final: {Robo.valorX} {Robo.valorY} {Robo.direcao}");

        Console.ReadLine();
    }
    static void ExibirCabecalho()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("-----Robô Tupiniquim-----");
        Console.WriteLine("-------------------------");
    }
}
