using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello();
            Welcome("John");
            AddTwoNums(10, 3);

            static string sayHello() {
                string hello = "Welcome friends! \nHave a nice day!";
                Console.WriteLine(hello);
                return hello;
            }

            static string Welcome(string name = "") {
                string welcome = "Welcome friend " + name + "!" + "\nHave a nice day!";
                Console.WriteLine(welcome);
                return welcome;
            }

            static string AddTwoNums(int n1, int n2) {
                int n3 = n1 + n2;
                Console.WriteLine("The sum of two numbers is: " + n3);
                string answer = Console.ReadLine();
                return answer;
            }
        }
    }
}
