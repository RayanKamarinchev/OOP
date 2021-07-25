using SOLID.Appenders;
using SOLID.Interfaces;
using SOLID.Layouts;
using SOLID.Loggers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IAppender> appenders = new List<IAppender>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0]=="ConsoleAppender")
                {
                    if (command[1] == "SimpleLayout")
                    {
                        appenders.Add(new ConsoleAppender(new SimpleLayout()));
                    }
                    else
                    {
                        appenders.Add(new ConsoleAppender(new XmlLayout()));
                    }
                }
                else
                {
                    if (command[1] == "SimpleLayout")
                    {
                        appenders.Add(new FileAppender(new SimpleLayout()));
                    }
                    else
                    {
                        appenders.Add(new FileAppender(new XmlLayout()));
                    }
                }
                if (command.Length==3)
                {
                    switch (command[2])
                    {
                        case "INFO":
                            appenders[appenders.Count - 1].ReportLevel = ReportLevel.Info;
                            break;
                        case "WARNING":
                            appenders[appenders.Count - 1].ReportLevel = ReportLevel.Warning;
                            break;
                        case "ERROR":
                            appenders[appenders.Count - 1].ReportLevel = ReportLevel.Error;
                            break;
                        case "CRITICAL":
                            appenders[appenders.Count - 1].ReportLevel = ReportLevel.Critical;
                            break;
                        case "FATAL":
                            appenders[appenders.Count - 1].ReportLevel = ReportLevel.Fatal;
                            break;
                        default:
                            break;
                    }
                }
            }

            string[] commandForOutput = Console.ReadLine().Split("|");
            while (commandForOutput[0]!="END")
            {
                foreach (IAppender appender in appenders)
                {
                    ILogger logger = new Logger(appender);
                    switch (commandForOutput[0])
                    {
                        case "INFO":
                            logger.Info(commandForOutput[1], commandForOutput[2]);
                            break;
                        case "WARNING":
                            logger.Warning(commandForOutput[1], commandForOutput[2]);
                            break;
                        case "ERROR":
                            logger.Error(commandForOutput[1], commandForOutput[2]);
                            break;
                        case "CRITICAL":
                            logger.Critical(commandForOutput[1], commandForOutput[2]);
                            break;
                        case "FATAL":
                            logger.Fatal(commandForOutput[1], commandForOutput[2]);
                            break;
                        default:
                            break;
                    }
                }
                commandForOutput = Console.ReadLine().Split("|");
            }

            foreach (var appender in appenders)
            {
                Console.WriteLine($"Logger info\n\nAppender type: {appender.GetType().Name}" +
                    $", Layout type: {appender.Layout.GetType().Name}, Report level: {appender.ReportLevel}" +
                    $", Messages appended: {appender.MessagesAppend}, File size ");
                int size = 0;
                string text = "";
                using (StreamReader sr = new StreamReader("Output.txt"))
                {
                    text = sr.ReadToEnd();
                }
                string onlyLetters = new String(text.Where(Char.IsLetter).ToArray());
                foreach (char symbol in onlyLetters)
                {
                    size += symbol;
                }
                Console.Write(size);
            }
        }
    }
}
