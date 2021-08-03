using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Actions act = new Actions();

            Console.Write("Enter user name: ");
            user1.Name = Console.ReadLine();

            Console.Write("Enter user surname: ");
            user1.Surname = Console.ReadLine();

            Console.Write("Enter user age: ");
        _REDO:
            bool success = int.TryParse(Console.ReadLine(), out int age);
            if (success)
            {
                user1.Age = age;
            }
            else
            {
                Console.WriteLine("You should enter integer number.");
                goto _REDO;
            }

            Console.Write("Enter user login: ");
            user1.Login = Console.ReadLine();

            Console.Clear();
            act.PrintUserInfo(user1);

            Console.ReadLine();
        }


    }
}
