using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class User
    {
        public string name;
        public string surname;
        public string Email;
        public string dateOfBirth;
        public bool isSingle;
        public Post[]post;

        public User()
        {

        }
        public User(string Name, string Surname) 
        {
            name = Name;
            surname = Surname;
        }
        public User(string Name, string Surname, string email) : this(Name, Surname)
        {
            Email = email;
        }
        public User(string Name, string Surname, string email,string DateOfBirth):this(Name,Surname,email)
        {
            dateOfBirth = DateOfBirth;
        }

    }
}
