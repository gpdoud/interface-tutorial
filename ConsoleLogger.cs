namespace bootcamp;

public class ConsoleLogger : ILogger
{
    public void Log(object message)
    {
        Console.WriteLine("Console: " + message.ToString());
    }
}
