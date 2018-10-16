using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = nameValid();
            string userEmail = emailValid();
            string userPhone = phoneValid();
            string userDate = dateValid();
        }
        public static string nameValid()
        {
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();

            if (!Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$"))
            {
                Console.WriteLine("I'm sorry, this is not a valid name");
            }
            else
            {
                Console.WriteLine("Name is valid");
            }
            return userName;
        }
        public static string emailValid()
        {
            Console.WriteLine("\nPlease enter your email address");
            string userEmail = Console.ReadLine();

            if (!Regex.IsMatch(userEmail, @"[A-z0-9]{5,30}(@)(.+){5,10}$"))
            {
                Console.WriteLine("I'm sorry this is not a valid email address");
            }
            else Console.WriteLine("Email address is valid");
            return userEmail;
        }
        public static string phoneValid()
        {
            Console.WriteLine("\nPlease enter your phone number");
            string userPhone = Console.ReadLine();

            if (!Regex.IsMatch(userPhone, @"^\(\d{3}\)-\d{3}-\d{4}$"))
            {
                Console.WriteLine("I'm sorry, this is not a valid phone number");
            }
            else
            {
                Console.WriteLine("Phone number is valid");
            }
            return userPhone;
        }
        public static string dateValid()
        {
            Console.WriteLine("\nEnter a date");
            string userDate = Console.ReadLine();

            if (!Regex.IsMatch(userDate, @"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"))
            {
                Console.WriteLine("I'm sorry, this is not a valid date");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Date is Valid");
                Console.ReadLine();
            }
            return userDate;
        }
    }
}