using LogManager.Interfaces;
using LogManager.Messages;
using Serilog;
using Serilog.Formatting.Json;

namespace LogManager
{
    public class Log : ILog 
    {
        private ILogger Logger { get; set; }

        public Log()
        {

        }

        public Log(string filepath)
        {
            Logger = new LoggerConfiguration().MinimumLevel.Debug()
                .WriteTo.RollingFile(new JsonFormatter(), filepath, retainedFileCountLimit: 10, shared: true)
                .CreateLogger();
        }

        public void LogError(Message obj)
        {            
            Logger.Error("{@" + obj.GetType().Name + "}", obj);
        }

        public void LogDebug(Message obj)
        {
            Logger.Debug("{@" + obj.GetType().Name + "}", obj);
        }

        public void LogWarning(Message obj)
        {
            Logger.Warning("{@" + obj.GetType().Name + "}", obj);
        }

        public void Dispose()
        {
            Serilog.Log.CloseAndFlush();
            Logger = null;
        }
    }
}
