using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
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
            get => numofMonths;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(NumOfMonths), "Number of months must be positive.");
                numofMonths = value;
            }
        }

        public int Price
        {
            get => price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Price), "Price can't be negative.");
                price = value;
            }
        }
    }
    public class PackageManager
    {
        private int id, numofCls, invitaionNum, discount;
        private string name, status;
        private MonthOffer mo;

        public PackageManager(int id = 0, int numofCls = 0, int invitaionNum = 0, int discount = 0, string name = "", string status = "", MonthOffer mo = null)
        {
            Id = id;
            NumOfClasses = numofCls;
            NumOfInvitations = invitaionNum;
            DiscountPercentage = discount;
            Name = name ?? string.Empty;    //not-nullable
            Status = status ?? string.Empty;
            MonthOffer = mo;
        }
        public int Id
        {
            get => id;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Id), "ID cannot be negative.");
                id = value;
            }
        }

        public int NumOfClasses
        {
            get => numOfClasses;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(NumOfClasses), "Number of classes cannot be negative.");
                numOfClasses = value;
            }
        }

        public int NumOfInvitations
        {
            get => numOfInvitations;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(NumOfInvitations), "Number of invitations cannot be negative.");
                numOfInvitations = value;
            }
        }

        public int DiscountPercentage
        {
            get => discountPercentage;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException(nameof(DiscountPercentage), "Discount percentage must be between 0 and 100.");
                discountPercentage = value;
            }
        }

        public string Name
        {
            get => name;
            set => name = value ?? string.Empty; // Ensuring name is never null.
        }

        public string Status
        {
            get => status;
            set => status = value ?? string.Empty; // Ensuring status is never null.
        }

        public MonthOffer MonthOffer
        {
            get => monthOffer;
            set => monthOffer = value;
        }
    }
}
