using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello();
            Welcome();

            static string sayHello() {
                string hello = "Welcome friends! \nHave a nice day!";
                Console.WriteLine(hello);
                return hello;
            }

            static string Welcome(string name = "John") {
                string welcome = "Welcome friend " + name + "!" + "\nHave a nice day!";
                Console.WriteLine(welcome);
                return welcome;
            }    
        }
    }
}
