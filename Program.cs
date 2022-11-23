namespace bootcamp;

public class Program
{
    private void Run()
    {
        Logger logger = new Logger(new ConsoleLogger());
        logger.Run();
    }

    public static void Main(string[] args)
    {
        new Program().Run();
    }
}
