namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() 
        {
            Console.Clear();
            System.Console.WriteLine("S = segundo => 10s => 10 segundos");
            System.Console.WriteLine("M = minuto => 10m => 10 minutos");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));

            int time = int.Parse(data.Substring(0, data.Length - 1));
            System.Console.WriteLine(type);
            System.Console.WriteLine(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);        
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2000);
        }
    }
}