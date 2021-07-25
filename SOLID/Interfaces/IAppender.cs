using SOLID.Appenders;

namespace SOLID
{
    internal interface IAppender
    {
        public ILayout Layout { get; set; }

        ReportLevel ReportLevel { get; set; }

        public int MessagesAppend { get; set; }

        void Append(string time, ReportLevel reportLevel, string message);
    }
}