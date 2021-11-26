using System;

class TestClass
{
    private static System.Timers.Timer Timer;

    static void Main()
    {
        CreateTimer();

        Console.WriteLine("Press enter to stop app...");
        Console.WriteLine("App started at {0:HH:mm:ss.fff}", DateTime.Now);
        Console.ReadLine();

        Timer.Stop();
        Timer.Dispose();

        Console.WriteLine("Exiting the app...");
    }

    private static void CreateTimer()
    {
        Timer = new System.Timers.Timer(2000);

        Timer.Elapsed += Timer_Elapsed;
        Timer.AutoReset = true;
        Timer.Enabled = true;
    }

    private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
    }
}