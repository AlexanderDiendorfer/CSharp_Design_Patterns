using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            UserContext myContext = UserContext.Instance;
            Console.WriteLine(myContext == UserContext.Instance);
        }
    }
}
