using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AdminSystem.Classes;

namespace AdminSystem.Query
{
    public class EmployeeQuery
    {
        private string GetSelectCol(bool incPic)
        {
            if (incPic) { return "*"; }
            else { return "ID,FIRSTNAME,USERNAME,GENDER,BIRTHDAY,EMAIL,PHONE,STATUS";
        }
        public List<EmployeeBase> Search(string search, bool incPic,bool byID = false, bool byUsername = false,bool byFullName = false)
        {
            try
            {
                List<EmployeeBase> emp = new List<EmployeeBase>();
                string query = "";

                if(byID && int.TryParse(search, out int id))
                {
                    query = $"SELECT {GetSelectCol(incPic)} FROM employee WHERE ID = {id}";
                }else if (byUsername)
                    {
                        query = $"SELECT {GetSelectCol(incPic)} FROM employee WHERE USERNAME = {search}";
                    }
                else if (byFullName)
                    {
                        query = $"SELECT {GetSelectCol(incPic)} FROM employee WHERE CONCAT(FIRSTNAME , ' ' , LASTNAME) = '{search}'";
                    }
                if(query == "")
                    {
                        Console.WriteLine($"Error getting from Employee Search: No selected search type");
                        return null;
                    }
                //SqlDataReader read = StaticClass.
            }
        }
    }
}
