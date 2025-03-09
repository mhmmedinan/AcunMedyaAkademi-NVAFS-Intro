namespace Core.Logger;

public class DatabaseLogger : ILogger
{
    public void Log(object ob)
    {
        Console.WriteLine($"Logged to database : {ob}");
    }
}
