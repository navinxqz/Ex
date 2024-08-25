using System;
namespace AdminSystem.DataAccess
{
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public bool Status { get; set; }
    }
}
