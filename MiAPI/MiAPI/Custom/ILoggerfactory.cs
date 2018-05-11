namespace MiAPI.Custom
{
    public interface ILoggerfactory
    {
        ILoggerfactory CreateLogger(string v);
        void LogInformation(string logString);
    }
}