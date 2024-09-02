using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminSystem.Classes;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace AdminSystem.Query
{
    public class TrainerQuery
    {
        private string GetCol(bool incPic)
        {
            if (incPic) { return "*"; }
            else { return "ID,FIRSTNAME,LASTNAME,BIRTHDAY,GENDER,EMAIL,PHONE,SPECIALIZED,LESSON_COST,STATUS"; }
        }
        public List<Trainer> Search(string search, bool incPic, bool byId = false, bool byFulName = false) {
            try
            {
                List<Trainer> trainers = new List<Trainer>();
                string query = "";

                if(byId && int.TryParse(search, out int id))
                {
                    query = $"SELECT {GetCol(incPic)} FROM ADMINSYSTEM.TRAINER WHERE ID = {id}";
                }else if (byFulName)
                {
                    query = $"SELECT {GetCol(incPic)} FROM ADMINSYSTEM.TRAINER CONCAT(FIRSTNAME, ' ', LASTNAME) = '{search}'";
                }

                if (string.IsNullOrEmpty(query))
                {
                    Console.WriteLine("Error! Nothing to search");
                    return null;
                }

                //using(MySqlConnection con = new MySqlConnection())

                MySqlDataReader read = StaticClass.sql.MySqlSelect(query);

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        Trainer t = new Trainer(id: Convert.ToInt32(read["ID"]), firstname: read["FIRSTNAME"].ToString(), lastname: read["LASTNAME"].ToString(), gender: read["GENDER"].ToString(), email: read["EMAIL"].ToString(), phone: read["PHONE"].ToString(), birthday: Convert.ToDateTime(read["BIRTHDAY"]), specialized: read["SPECIALIZED"].ToString(), lessonPrice: Convert.ToInt32(read["LESSON_COST"]), status: Convert.ToBoolean(read["STATUS"]));
                        if (incPic) {
                            t.Pic = StaticClass.imgManager.ImgbaseToImg(read["PICTURE"].ToString());
                            t.ImgBase = read["PICTURE"].ToString();
                        }
                        trainers.Add(t);
                    }return trainers;
                }
                else
                {
                    Console.WriteLine($"Error! No records found for ID or username '{search}'");
                    return null;
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Error! {ex.Message}");
                return null;
            }
        } 
    }
}
