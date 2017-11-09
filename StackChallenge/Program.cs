using System;

namespace StackChallenge
{
    class Program
    {
        static MyStack _myStack = new MyStack();

        static void Main(string[] args)
        {
            PrintOptions();

            Console.Write("OPTION:  ");
            var key = Console.ReadLine();

            while (key == "1" || key == "2" || key == "3")
            {
                try
                {
                    DoWork(key);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong: {ex.Message} Please try again...");
                }

                Console.WriteLine();
                Console.Write("OPTION:  ");
                key = Console.ReadLine();
            }
        }

        static void PrintOptions()
        {
            Console.WriteLine("Welcome to My Stack.");
            Console.WriteLine("     Press 1 to PUSH a value.");
            Console.WriteLine("     Press 2 to POP a value.");
            Console.WriteLine("     Press 3 to get the MIN value.");
            Console.WriteLine("     Press any other key to exit.");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }

        static void DoWork(string key)
        {
            switch (key)
            {
                case "1":
                    Console.WriteLine("What integer value do you wanna push?");
                    var value = Console.ReadLine();

                    if (!int.TryParse(value, out int integer))
                        Console.WriteLine("Only integer values are allowed!");
                    else
                        _myStack.Push(integer);

                    break;
                case "2":
                    _myStack.Pop();
                    break;
                case "3":
                    Console.WriteLine($"Min value: {_myStack.Min()}");
                    break;
            }
        }

        
    }
}
