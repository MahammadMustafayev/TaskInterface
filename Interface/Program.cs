using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bu Qeder Yaza Bildim*/
            Console.WriteLine("Id daxil et:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FullName Daxil edin:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Email daxil edin:");
            string email = Console.ReadLine();

            string password;
            do
            {
                Console.WriteLine("Password daxil edin:");
                password = Console.ReadLine();

            } while (password.Length > 8 || password == password.ToLower() || password == password.ToUpper() );

            User  user = new User(email,password);
            Console.WriteLine(user.PasswordChecker(password));
            user.ShowInfo(id,fullName,email);
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

    class User : IAccount
    {
       

        public int Id { get; }

        public string FullName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
        public User(int id, string fullName, string email,string password)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Email = email;
            this.Password = password;
        }

        public bool PasswordChecker(string Password)
        {
            return true;
        }

        public void ShowInfo(int Id,string FullName,string Email)
        {
            Console.WriteLine($"Id deyeri:{Id} Butun adi:{FullName} Email:{Email}");
        }
    }
}
