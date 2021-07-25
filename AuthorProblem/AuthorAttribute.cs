using System;

namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method, AllowMultiple = true)]
    class AuthorAttribute : Attribute
    {
        public string AuthorName { get; set; }
        public AuthorAttribute(string name)
        {
            AuthorName = name;
        }
    }
}
