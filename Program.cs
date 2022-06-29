// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("O => Sair");
        Console.WriteLine("Informe o tempo de contagem: ");
        //variavel data para armazenar a escolha do usuario e .ToLower para transformar em minuscula a letra.
        string data = Console.ReadLine().ToLower();
        //type char para armazenar apenas um caracter.
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        int multiplier = 1;//multiplicador

        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Preparar...");
        Thread.Sleep(1000);
        Console.WriteLine("Apontar...");
        Thread.Sleep(1000);
        Console.WriteLine("Go");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;
        //Laço de repetição para iterar o tempo
        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);//Metodo para parar a aplicação.
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado");
        Thread.Sleep(2500);
        Menu();
    }
}
