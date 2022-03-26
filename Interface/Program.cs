using System;
using System.Linq;
using Interface.Models;

namespace Interface
{
    class Program
    {
        public static object Id { get; private set; }

        static void Main(string[] args)
        {
            Start:
            string fullName;
            try
            {
                Console.WriteLine("FullName Daxil edin:");
                fullName = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

            string email;
            try
            {
                Console.WriteLine("Email daxil edin:");
                email = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            
            string password;
            try
            {
                do
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Password daxil edin:");
                    Console.WriteLine("Password daxil edilerken en az 1 reqem,1 boyuk herf ,1 kicik herf daxil edilmelidir.Yazi yerini bos saxlamaq olmaz");
                    password = Console.ReadLine();

                } while (password.Length > 8 || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password) || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

            User user1 = new User(email,password);
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Password sertlerini odeyirmi:{user1.PasswordChecker(password)}");
            Console.WriteLine("------------------------------------");
            user1.ShowInfo(fullName);
        }
    }

    public interface IAccount
    {
        public void PasswordChecker(string password)
        {
           
        }

        public void ShowInfo()
        {

        }

    }

    
}
