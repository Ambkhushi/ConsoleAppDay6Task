using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay6Task
{
    public class ValidationException:Exception
    {
       public ValidationException(string message): base(message)
        {
        }
    }
    public class UserRegistrationSystem
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("user registration");
                Console.Write("Enter your name :");
                string name = Console.ReadLine();
                Console.Write("Enter your email:");
                string email = Console.ReadLine();
                Console.Write("Enter your Password:");
                string password = Console.ReadLine();

                ValidateName(name);
                ValidateEmail(email);
                ValidatePassword(password);

                Console.WriteLine("Registration Successful!");
            }
            catch(ValidationException ex)
            {
                Console.WriteLine("Registration failed:" + ex.Message);
            }
        }
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ValidationException("Name is required.");
            }
            if (name.Length < 6)
            {
                throw new ValidationException("Name should be at least 6 characters long.");
            }
        }
        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ValidationException("email is required.");
            }
            if (!email.Contains('@') || !email.Contains("."))
            {
                throw new ValidationException("Invalid email format.");
            }
        }
        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ValidationException("Password is required.");
            }
            if (password.Length < 6)
            {
                throw new ValidationException("Password should be at least 6 characters long.");
            }
        }
    }
}
