﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace AdminSystem.Classes
{
    public abstract class Person
    {
        protected int id = 0, age ;
        protected string firstname = null, lastname = null;
        protected string gender = null, imgbase = null;
        protected string email = null, phone = null;
        protected string password = null;
        protected DateTime birthday = default;
        protected Image pic = null;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Name { get { return (firstname + " " + lastname); } }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string ImgBase
        {
            get { return imgbase; }
            set { imgbase = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                age = AgeCalc(birthday); // Recalculate age when birthday changes
            }
        }

        public int Age
        {
            get { return age; }
        }

        public Image Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        public Person(int id,string firstname,string lastname,string gender, string imgbase,string email, string phone,string password,DateTime birthday, Image pic ) {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            ImgBase = imgbase;
            Email = email;
            Phone = phone;
            Password = password;
            Birthday = birthday;
            Pic = pic;
        }

        private int AgeCalc(DateTime birthDate)
        {
            var today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) { age--; }
            return age;
        }
        public abstract int GenerateID();   //to b implemented by derived cls
    }
}
