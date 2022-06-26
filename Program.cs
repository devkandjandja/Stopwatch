// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        Start();
    }

    static void Start()
    {
        int time = 10;
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
    }
}
