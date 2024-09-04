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
        public int Id
        {
            get => id;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Id), "ID can't be negative.");
                id = value;
            }
        }

        public int MaxNum
        {
            get => maxNum;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(MaxNum), "Max number of freezes can't be negative.");
                maxNum = value;
            }
        }

        public int NumOfMonths
        {
            get => numOfMonths;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(NumOfMonths), "Number of months must be positive.");
                numOfMonths = value;
            }
        }

        public int Price
        {
            get => price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Price), "Price cannot be negative.");
                price = value;
            }
        }
    }
    public class PackageManager
    {
        private int id, clsName, invitaionNum, discount;
        private string name, status;
        //private 
    }
}
