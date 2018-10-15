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

            while (!Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$"))
            {
                Console.WriteLine("I'm sorry, this is not a valid name");
                userName = Console.ReadLine();
            }
            return userName;
        }
        public static string emailValid()
        {
            Console.WriteLine("Please enter your email address");
            string userEmail = Console.ReadLine();

            while (!Regex.IsMatch(userEmail, @"[A-z0-9]{5,30}(@)(.+){5,10}$"))
            {
                Console.WriteLine("I'm sorry this is not a valid email address");
                userEmail = Console.ReadLine();
            }
            return userEmail;
        }
        public static string phoneValid()
        {
            Console.WriteLine("Please enter your phone number");
            string userPhone = Console.ReadLine();

            while (!Regex.IsMatch(userPhone, @"^\(\d{3}\)-\d{3}-\d{4}$"))
            {
                Console.WriteLine("I'm sorry, this is not a valid phone number");
                userPhone = Console.ReadLine();
            }
            return userPhone;
        }
        public static string dateValid()
        {
            Console.WriteLine("Enter a date");
            string userDate = Console.ReadLine();

            while (!Regex.IsMatch(userDate, @"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"))
            {
                Console.WriteLine("I'm sorry, this is not a valid date");
                userDate = Console.ReadLine();
            }
            return userDate;
        }
    }
}