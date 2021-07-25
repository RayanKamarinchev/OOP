using System;
using System.Linq;
using System.Reflection;

namespace AuthorProblem
{
    class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic|BindingFlags.Static
                |BindingFlags.Public|BindingFlags.Instance);
            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    object[] atributes = type.GetCustomAttributes(false);
                    foreach (AuthorAttribute item in atributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {item.AuthorName}");
                    }
                }
            }
        }
    }
}
