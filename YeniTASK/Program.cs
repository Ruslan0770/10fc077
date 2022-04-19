using System;
using YeniTASK.Models;

namespace YeniTASK
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("ad daxil et");
            string a = Console.ReadLine();
            Console.WriteLine("email da");
            string b = Console.ReadLine();
            user.ShowInfo(a,b);
            Console.WriteLine("Sifreni daxil et");
            user.PasswordChecker(Console.ReadLine());
        }
    }
}
