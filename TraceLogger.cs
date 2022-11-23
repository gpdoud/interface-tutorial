namespace bootcamp;

public class TraceLogger : ILogger
{
    public void Log(object message)
    {
        System.Diagnostics.Trace.WriteLine("Trace: " + message.ToString());
    }
}
