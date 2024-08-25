using System;
using System.Drawing;

namespace AdminSystem.Classes
{
    public class EmployeeBase : Person
    {
        private static EmployeeBase instance;
        private string username;
        private bool status;

        private EmployeeBase() : base(0, null, null, null, null, null, null, null, default, null)
        {
        }

        public EmployeeBase(int id, string firstname, string lastname, string gender, string imgbase, string email, string phone, string password, DateTime birthday, Image pic,string username,bool status):base(id,firstname,lastname,gender,imgbase,email,phone,password,birthday,pic) {
            this.username = username;
            this.status = status;
        }
        public string Username {  get { return username; } set {  username = value; } }
        public bool Status { get { return status; } set { status = value; } }
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

            //double currentYear = DateTime.Now.Year;
            //currentYear = (((currentYear % 100) / 100) + 1) * 1000000;
            //int y = (int)currentYear;
            //    int lastID = StaticClass.
            return 0;
        }
    }
}
