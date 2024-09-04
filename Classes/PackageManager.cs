using System;
namespace AdminSystem.Classes
{
    public class MonthOffer
    {
        private int id, maxNum, numofMonths, price;

        public MonthOffer(int id = 0, int maxNum = 0, int numOfMonths = 0, int price = 0)
        {
            Id = id;
            MaxNum = maxNum;
            NumOfMonths = numOfMonths;
            Price = price;
        }
    }
    public class PackageManager
    {
        private int id, clsName, invitaionNum, discount;
        private string name, status;
        //private 
    }
}
