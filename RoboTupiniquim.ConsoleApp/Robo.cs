namespace RoboTupiniquim.ConsoleApp;

static class Robo
{
    public static int valorX;
    public static int valorY;
    public static char direcao;
    public static void Configurar(int pX, int pY, char dir)
    {
        valorX = pX;
        valorY = pY;
        direcao = dir;
    }
    public static void ExecutarComando(string comandoCompleto)
    {
        foreach (char comando in comandoCompleto!)
        {
            if (comando == 'E') GirarParaEsquerda();

            if (comando == 'D') GirarParaDireita();

            if (comando == 'M') Avancar();
        }
    }
    public static void GirarParaEsquerda()
    {
        if (direcao == 'N') direcao = 'O';
        else if (direcao == 'O') direcao = 'S';
        else if (direcao == 'S') direcao = 'L';
        else if (direcao == 'L') direcao = 'N';
    }

    public static void GirarParaDireita()
    {
        if (direcao == 'N') direcao = 'L';
        else if (direcao == 'L') direcao = 'S';
        else if (direcao == 'S') direcao = 'O';
        else if (direcao == 'O') direcao = 'N';
    }

    public static void Avancar()
    {
        if (direcao == 'N') valorY++;
        else if (direcao == 'O') valorX--;
        else if (direcao == 'S') valorY--;
        else if (direcao == 'L') valorX++;
    }
}