using System.Reflection;

namespace Reflections_Practice_FindNearestNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            NearestNumber.FindNearestNumber(-33);
            Type type = typeof(NearestNumber);
            Console.WriteLine("Fetching Methods");
            Console.WriteLine("-----------------");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("");
            Console.WriteLine("Fetching Constructors");
            Console.WriteLine("----------------------");
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }
            Console.WriteLine("");
            Console.WriteLine("Fetching Properties");
            Console.WriteLine("---------------------");
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property.Name);
            }
            //Default Constructor Object
            NearestNumber.FindNearestNumber(0);
        }
    }
}