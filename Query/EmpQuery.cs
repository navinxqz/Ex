﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AdminSystem.Classes;

namespace AdminSystem.Query
{
    public class EmpQuery
    {
        private string GetCol(bool incPic)
        {
            return incPic ? "*" : "ID, FIRSTNAME, LASTNAME, DOB, GENDER, EMAIL, PHONE, USERNAME, PASSWORD, STATUS, ADMIN";
        }
        public List<EmployeeBase> Search(string search,bool incPic,bool byId = false, bool byUsername = false, bool byFulName = false)
        {
            try
            {
                List <EmployeeBase> Ebase = new List<EmployeeBase>();
                string query = "";

                if(byId && int.TryParse(search, out int id))
                {
                    query = $"SELECT {GetCol(incPic)} FROM adminsystem.employee WHERE ID = {id}";
                }else if (byUsername)
                {
                    query = $"SELECT {GetCol(incPic)} FROM adminsystem.employee WHERE USERNAME = '{search}'";
                }else if (byFulName)
                {
                    query = $"SELECT {GetCol(incPic)} FROM adminsystem.employee WHERE CONCAT(FIRSTNAME, ' ',LASTNAME) = '{{search}}'";
                }
                if(string.IsNullOrEmpty(query))
                {
                    Console.WriteLine($"Error Employee value!");
                    return null;    //null return
                }


                MySqlDataReader read = StaticClass.sql.MySqlSelect(query);
                if(read.HasRows)
                {
                    while(read.Read())
                    {
                        EmployeeBase eb = new EmployeeBase(id: Convert.ToInt32(read["ID"]), firstname: read["FIRSTNAME"].ToString(), lastname: read["LASTNAME"].ToString(), birthday: Convert.ToDateTime(read["DOB"]), gender: read["GENDER"].ToString(), email: read["EMAIL"].ToString(), phone: read["PHONE"].ToString(), admin: Convert.ToBoolean(read["ADMIN"]), status: Convert.ToBoolean(read["STATUS"]), username: read["USERNAME"].ToString());
                        if (incPic)
                        {
                            eb.Pic = StaticClass.imgManager.ImgbaseToImg(read["img"].ToString());
                            eb.ImgBase = read["img"].ToString();
                        }
                        Ebase.Add(eb);
                    }
                    return Ebase;
                }
                else
                {
                    Console.WriteLine($"Error! No records found '{search}'");
                    return null;
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
                return null;
            }
        }
    }
}
