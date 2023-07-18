using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var tasks = new Task[3];
        tasks[0] = Task.Run(() => LongRunningMethod("Task 1"));
        tasks[1] = Task.Run(() => LongRunningMethod("Task 2"));
        tasks[2] = Task.Run(() => LongRunningMethod("Task 3"));

        Task.WaitAll(tasks);
    }

    static void LongRunningMethod(string taskName)
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine($"{taskName} is running ({i}/1000)");
        }
    }
}
