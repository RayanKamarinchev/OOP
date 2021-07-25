using SOLID.Appenders;
using SOLID.Interfaces;

namespace SOLID.Loggers
{
    class Logger : ILogger
    {
        public IAppender Appender { get; set; }

        public Logger(IAppender appender)
        {
            Appender = appender;
        }

        public void Info(string time, string message)
        {
            Appender.Append(time, ReportLevel.Info, message);
        }

        public void Warning(string time, string message)
        {
            Appender.Append(time, ReportLevel.Warning, message);
        }

        public void Error(string time, string message)
        {
            Appender.Append(time, ReportLevel.Error, message);
        }

        public void Critical(string time, string message)
        {
            Appender.Append(time, ReportLevel.Critical, message);
        }

        public void Fatal(string time, string message)
        {
            Appender.Append(time, ReportLevel.Fatal, message);
        }
    }
}
