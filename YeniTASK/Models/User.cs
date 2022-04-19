﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YeniTASK.Models
{
    class User:Account
    {
        public string Fullname;
        public string Email;
        public string Password;

        public bool PasswordChecker(string password)
        {


            bool check = true;
            bool avg = false;

            while (check)
            {
                bool checkLower = false;
                bool checkUpper = false;
                bool checkDigit = false;

                if (password.Length >= 8)
                {
                    foreach (char item in password)
                    {
                        if (char.IsUpper(item))
                        {
                            checkUpper = true;
                        }
                        else if (char.IsLower(item))
                        {
                            checkLower = true;
                        }
                        else if (char.IsDigit(item))
                        {
                            checkDigit = true;
                        }

                        if (checkLower == true && checkUpper && checkDigit)
                        {

                            check = false;
                            avg = true;
                            Console.WriteLine("sifre duzgundur");

                            break;
                        }
                    }

                    if (checkDigit == false || checkLower == false || checkUpper == false)
                    {
                        Console.WriteLine("Sifreni Duzgun Daxil Et:");
                        password = Console.ReadLine();
                        avg = false;
                    }
                }
                else
                {
                    Console.WriteLine("Sifre Minimum 8 simvol Olmalidir");
                    password = Console.ReadLine();
                    avg = false;
                }

            }

            return avg;
        }

        public void ShowInfo(string Fullname,string Email)
        {
            Console.WriteLine($"Tam ad {Fullname}\n email adresi {Email}");
        }
    }
}
