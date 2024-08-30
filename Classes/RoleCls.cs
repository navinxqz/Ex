using System;
using System.Collections.Generic;

namespace AdminSystem.Classes
{
    public class RoleCls
    {
        public int Id { get; set; }
        public int EnrollmentNo { get; set; }
        public int MaxEnrollment { get; set; }
        public int Pricing { get; set; }
        public string Name { get; set; }
        public string SessionDay1 { get; set; }
        public string SessionDay2 { get; set; }
        public bool Status { get; set; }
        //public TrainerModel? TrainerModel { get; set; }

        //private 
        public RoleCls(int id=0, int enrollmentNo=0,int maxEnrollment=0,int pricing=0,
           string name=null, string sessionDay1=null, string sessionDay2 = null, bool status = false)
        {
            Id = id;
            EnrollmentNo = enrollmentNo;
            MaxEnrollment = maxEnrollment;
            Pricing = pricing;
            Name = name;
            SessionDay1 = sessionDay1;
            SessionDay2 = sessionDay2;
            Status = status;
            //trainers in future...
        }


    }
}
