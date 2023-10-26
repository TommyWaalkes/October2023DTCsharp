using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProperties
{
    internal class Login
    {
        //If you customize a either the get or set, you must customize the other. 
        public string Email
        {
            get
            {
                if (LoggedIn)
                {
                    return _email;
                }
                else
                {
                    return "You are not loggedIn";
                }

            }set { 
                //When we call and set a property equal to new value. 
                //The setter kicks and pull the new value into the value keyword
                _email = value;
            } }

        //any private instance variables start with an underscore in C# and are also lowercased. 
        //In older code this pattern was more common. 
        //To be honest it's faster to do normal gets and set unless you need to control access to a varialbe
        private string _email;
        public string UserName { get
            { return _userName; }
            
            set { 
            if(LoggedIn)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("You are not logged in userName not updated");
                }
            } }
        private string _userName;
        public string  Password { get; set; }
        public bool LoggedIn { get; set; } = false; 

        public Login(string email, string userName, string password)
        {
            Email = email;
            _userName = userName;
            Password = password;
        }

        public void CheckLogin(string email, string userName, string password)
        {
            if(userName == UserName && 
                _email == email && 
                Password == password)
            {
                LoggedIn = true;
            }
            else
            {
                LoggedIn = false;
            }
        }

        //Properties are shorthand for getter and setter methods. 
        //In many other OOP languages this is how you manage your object variables
        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
