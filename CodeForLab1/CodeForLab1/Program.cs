using System;

namespace CodeForLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (CheckPassword(username, password))
            {
                Console.WriteLine("Access is allowed.");
                Console.WriteLine(ResultCashback(username, 10000));
            }
            else
            {
                Console.WriteLine("Access is denied");
            }


            Console.ReadKey();
        }

        static bool CheckPassword(string user, string password)
        {
            if (user.Equals("admin") || password.Equals("123456")) return true;
            else if (user.Equals("user") || password.Equals("guest")) return true;
            else return false;
        }

        static int ResultCashback(string user, int money)
        {
            float coeffAdmin = 1.5f;
            float coeffUser = 1.2f;
            return money * (int) coeffAdmin;
            return money * (int)coeffUser;
        }
    }


}
