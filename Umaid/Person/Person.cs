using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Model
{
    public class Person
    {
        string userID;
        string password;
        string fName;
        string lName;
        string emailAddress;
        int phoneNumber;
        string userType;

        public Person(string userID, string password, string fName, string lName,
            string emailAddress, int phoneNumber, string userType)
        {
            this.userID = userID;
            this.password = password;
            this.fName = fName;
            this.lName = lName;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
            this.userType = userType;
        }

        public string UserID { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public string TypeUser { get; set; }


        public void Register()
        {
            Console.WriteLine("First Name: ");
            fName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            lName = Console.ReadLine();

            Console.WriteLine("Email: ");
            emailAddress = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            phoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your username is: " + emailAddress);

            Console.WriteLine("Enter a password: ");
            password = Console.ReadLine();

            Console.WriteLine("Are you a customer or a maid?");
            userType = Console.ReadLine();

            Console.WriteLine("Profile Created");
        }

        public void Login()
        {
            Console.WriteLine("Enter your username: ");
            userID = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();

            Username();
            ValidatePassword();
        }

        protected string ValidatePassword()
        {
            var regex = new Regex("^[a-zA-Z0-9]*$");

            if (password.Length < 8)
                Console.WriteLine("Password is less than 8 characters");

            Match match = regex.Match(password);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Incorrect Password");
                Login();
            }

            return password;
        }
       
        protected string Username()
        {
            if (userID != emailAddress)
            {
                Console.WriteLine("Username is invalid");
                Login();
            }
            else
            {

            }
            return userID;
        }

        public void Type()
        {
            if(userType == "maid")
            {

            }
            else if(userType == "customer")
            {

            }
        }
    }
}