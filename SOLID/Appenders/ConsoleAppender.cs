using System;

namespace SOLID.Appenders
{
    class ConsoleAppender : IAppender
    {
        public ILayout Layout { get; set; }
        public ReportLevel ReportLevel { get; set; } = ReportLevel.Info;
        public int MessagesAppend { get; set; }

        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
        }

        public void Append(string time, ReportLevel reportLevel, string message)
        {
            if (reportLevel>=ReportLevel)
            {
                Console.WriteLine(Layout.Template, time, reportLevel, message);
                MessagesAppend++;
            }
        }
    }
}
