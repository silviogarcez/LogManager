using LogManager.Messages;

namespace LogManager.Interfaces
{
    public interface ILog
    {        
        void LogError(Message obj);
        void LogDebug(Message obj);
        void LogWarning(Message obj);
    }
}
