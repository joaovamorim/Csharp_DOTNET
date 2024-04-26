// using System.Threading;

namespace ThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Tarefa));
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
            }

            Console.ReadKey();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada.");
            }
        }
    }
}