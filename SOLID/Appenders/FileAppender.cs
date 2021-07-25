using System;
using System.IO;

namespace SOLID.Appenders
{
    class FileAppender : IAppender
    {
        public ILayout Layout { get ; set ; }
        public ReportLevel ReportLevel { get; set; } = ReportLevel.Info;
        public int MessagesAppend { get; set; }

        public FileAppender(ILayout layout)
        {
            Layout = layout;
        }

        public void Append(string time, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= ReportLevel)
            {
                string oldFile = "";
                using (StreamReader sr = new StreamReader("Output.txt"))
                {
                    oldFile = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter("Output.txt"))
                {
                    sw.WriteLine(oldFile);
                    sw.WriteLine(Layout.Template, time, reportLevel, message);
                }
                MessagesAppend++;
            }
        }
    }
}
