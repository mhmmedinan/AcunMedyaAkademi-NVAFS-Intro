namespace Core.Logger;

public class FileLogger:ILogger
{
    public void Log(object ob)
    {
        Console.WriteLine($"Logged to file : {ob}");
    }
}
