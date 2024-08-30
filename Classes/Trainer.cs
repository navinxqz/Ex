using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;

namespace AdminSystem.Classes
{
    public class Trainer : Person
    {
        public string Specialized {  get; set; }
        public int LessonPrice {  get; set; }
        public bool Status {  get; set; }

        public Trainer(int id =0, string firstname=null, string lastname = null, string gender = null, string imgbase = null, string email = null, string phone = null, string password = null, DateTime birthday=default, Image pic =null, string specialized = null, int lessonPrice=0, bool status=false) 
            : base(id, firstname, lastname, gender, imgbase, email, phone, password, birthday, pic)
        { 
            Specialized = specialized;
            LessonPrice = lessonPrice;
            Status = status;
        }

        public override int GenerateID()
        {
            int year = (DateTime.Now.Year % 100) + 3;
            int baseId = year * 1000000; // Create a base ID with the prefix.
            int newId;

            /*int lastId = StaticClass.trainerService.getLastId();
            if (lastId == -1)
            {
                Console.WriteLine("Error: Unable to get last ID.");
                return -1;
            }

            // Determine new ID based on last ID
            int newId = (lastId == 0 || (lastId / 1000000) != (baseId / 1000000)) ? baseId + 1 : lastId + 1;    */

            this.id = newId;
            return newId;
        }
    }
}
