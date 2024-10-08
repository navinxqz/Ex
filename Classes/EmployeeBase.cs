﻿using System;
using System.Drawing;
namespace AdminSystem.Classes
{
    public class EmployeeBase : Person
    {
        private static EmployeeBase instance;
        private string username;
        private bool admin,status;

        public EmployeeBase(int id =0, string firstname = null,string imgbase=null, string lastname=null, string username = null, string password = null, string gender =null, string email=null, string phone = null, bool admin = false, bool status = false, DateTime birthday= default, Image pic = null) 
            : base(id, firstname, lastname, gender, imgbase, email, phone, password, birthday,pic)
        {
            Username = username;
            Admin = admin;
            Status = status;
        }
        public string Username {  get { return username; } set {  username = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public bool Admin { get { return admin; } set { admin = value; } }

        public static EmployeeBase Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new EmployeeBase();
                }return instance;
            }
        }

        public override int GenerateID()
        {
            //Random r = new Random();
            //return r.Next(1,10000);

            int id;
            double currentYear = DateTime.Now.Year;
            currentYear = (((currentYear % 100) / 100) + 1) * 1000000;
            int y = (int)currentYear;
            int lastID = StaticClass.empQuery.lastID();

            if(lastID != -1) { return -1; }
            if(lastID== 0 || (lastID/ 1000000) != (y/ 1000000)) { id = ++y; }
            else {  id = lastID +1; }
            
            this.id = id;
            return id;
        }
    }
}
