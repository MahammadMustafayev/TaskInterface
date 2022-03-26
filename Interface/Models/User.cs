using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface.Models
{
    class User : IAccount
    {
        private static int _id = 0;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private User()
        {
            ++_id;
            Id = _id;
        }

        public User(string email, string password) : this()
        {
            Email = email;
            Password = password;
        }


        public bool PasswordChecker(string password)
        {
            /* Lazim Olsa Deye*/

            //if (string.IsNullOrEmpty(password))
            //{
            //    Console.WriteLine("Password null ola bilmez");
            //    return false;
            //}
            //else if (string.IsNullOrWhiteSpace(password))
            //{
            //    Console.WriteLine("Passwordda bosluq ola bilmez");
            //    return false;
            //}
            //else if (!password.Any(char.IsUpper))
            //{
            //    Console.WriteLine("En az bir boyuk herf olmalidir");
            //    return false;
            //}
            //else if (!password.Any(char.IsLower))
            //{
            //    Console.WriteLine("En az bir kicik herf olmalidir");
            //    return false;
            //}
            //else if (!password.Any(char.IsDigit))
            //{
            //    Console.WriteLine("En az bir reqem  olmalidir");
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return true;
        }

        public void ShowInfo(string FullName)
        {
            Console.WriteLine($"Id deyeri:{Id} , Butun adi:{FullName} , Email:{Email}");
        }
    }
}
