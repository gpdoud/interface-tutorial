namespace bootcamp;

public class Logger
{
    private ILogger _logger;

    public void Run()
    {
        _logger.Log("Begin Logger ...");
        _logger.Log("1st log message");
        _logger.Log("2nd log message");
        _logger.Log("3rd log message");
        _logger.Log("End Logger ...");
    }

    public Logger(ILogger logger)
    {
        _logger = logger;
    }
}
