using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    class Spy
    {
        public string StealFieldInfo(string clas, string[] fields)
        {
            Type type = Type.GetType(clas);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {type.Name}");
            object inst = Activator.CreateInstance(type);
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public
                |BindingFlags.Static|BindingFlags.Instance); 
            foreach (var field in fields)
            {
                foreach (var fieldInfo in fieldInfos)
                {
                    if (fieldInfo.Name == field)
                    {
                        sb.AppendLine($"{fieldInfo.Name} = {fieldInfo.GetValue(inst)}");
                    }
                }
            }
            return sb.ToString();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type type = Type.GetType(className);
            StringBuilder sb = new StringBuilder();
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public|BindingFlags.Instance);
            foreach (var fieldName in fieldInfos)
            {
                sb.AppendLine($"{fieldName.Name} must be private!");
            }
            PropertyInfo[] propInfoForGetters = type.GetProperties(BindingFlags.NonPublic|BindingFlags.Instance);
            foreach (var prop in propInfoForGetters)
            {
                sb.AppendLine($"get_{prop.Name} have to be public!");
            }
            PropertyInfo[] propInfoForSetters = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in propInfoForSetters)
            {
                if (property.SetMethod.IsPublic)
                {
                    sb.AppendLine($"set_{property.Name} have to be private!");
                }
            }
            return sb.ToString();
        }

        public string RevealPrivateMethods(string className)
        {
            Type type = Type.GetType(className);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");
            MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var method in methods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type type = Type.GetType(className);
            StringBuilder sb = new StringBuilder();
            MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance
                |BindingFlags.Public);
            foreach (var method in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters()}");
            }
            return sb.ToString();
        }
    }
}
