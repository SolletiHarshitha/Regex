﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class User
    {
        //Pattern for validating the name
        string namePattern = "^[A-Z][a-z]{2,}$";
        /// <summary>
        /// UC - 1  Validating the First Name
        /// </summary>
        public void ValidateFirstName()
        {
            Console.WriteLine("Enter a First Name to validate : ");
            string firstName = Console.ReadLine();
            Regex regex = new Regex(namePattern);
            bool result = regex.IsMatch(firstName);
            if(result)
                Console.WriteLine("It is valid");
            else
                Console.WriteLine("It is not valid");
        }
        /// <summary>
        /// UC - 2  Validating the Last Name
        /// </summary>
        public void ValidateLastName()
        {
            Console.WriteLine("Enter a Last Name to validate : ");
            string lastName = Console.ReadLine();
            Regex regex = new Regex(namePattern);
            bool result = regex.IsMatch(lastName);
            if (result)
                Console.WriteLine("It is valid");
            else
                Console.WriteLine("It is not valid");
        }
        //Pattern for validating the email
        string emailPattern = "^[abc.a-z]+@[bl.co.a-z]";
        /// <summary>
        /// UC - 3  Validating the Email
        /// </summary>
        public void ValidateEmail()
        {
            Console.WriteLine("Enter an Email to validate : ");
            string email = Console.ReadLine();
            Regex regex = new Regex(emailPattern);
            bool result = regex.IsMatch(email);
            if (result)
                Console.WriteLine("It is valid");
            else
                Console.WriteLine("It is not valid");
        }
        //Pattern for validating the Mobile Number
        string numberPattern = "^[0-9]+[\\s]+[0-9]{10}$";
        /// <summary>
        /// UC - 4  Validating the Mobile Number
        /// </summary>
        public void ValidateMobileNumber()
        {
            Console.WriteLine("Enter a Mobile Number to validate : ");
            string mobileNumber = Console.ReadLine();
            Regex regex = new Regex(numberPattern);
            bool result = regex.IsMatch(mobileNumber);
            if (result)
                Console.WriteLine("It is valid");
            else
                Console.WriteLine("It is not valid");
        }
        //Pattern for validating the password
        string passwordPattern="^[a-z]{7,}$";
        /// <summary>
        /// UC - 5  Validating the Password
        /// </summary>
        public void ValidatePassword()
        {
            Console.WriteLine("Enter a Password to validate : ");
            string password = Console.ReadLine();
            Regex regex = new Regex(passwordPattern);
            bool result = regex.IsMatch(password);
            if (result)
                Console.WriteLine("It is valid");
            else
                Console.WriteLine("It is not valid");
        }
    }
}
