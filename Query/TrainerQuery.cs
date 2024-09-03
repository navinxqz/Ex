using System;
using System.Collections.Generic;
using AdminSystem.Classes;
using MySql.Data.MySqlClient;

namespace AdminSystem.Query
{
    public class TrainerQuery
    {
        private string GetCol(bool incPic)
        {
            if (incPic) { return "*"; }
            else { return "ID,FIRSTNAME,LASTNAME,BIRTHDAY,GENDER,EMAIL,PHONE,SPECIALIZED,LESSON_COST,STATUS"; }
        }
        public List<Trainer> Search(string search, bool incPic, bool byId = false, bool byFulName = false)
        {
            try
            {
                List<Trainer> trainers = new List<Trainer>();
                string query = "";

                if (byId && int.TryParse(search, out int id))
                {
                    query = $"SELECT {GetCol(incPic)} FROM ADMINSYSTEM.TRAINER WHERE ID = @id";
                }
                else if (byFulName)
                {
                    query = $"SELECT {GetCol(incPic)} FROM ADMINSYSTEM.TRAINER WHERE CONCAT(FIRSTNAME, ' ', LASTNAME) = '{search}'";
                }

                if (string.IsNullOrEmpty(query))
                {
                    Console.WriteLine("Error! Nothing to search");
                    return null;
                }

                MySqlDataReader read = StaticClass.sql.MySqlSelect(query);
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        Trainer t = new Trainer(id: Convert.ToInt32(read["ID"]), firstname: read["FIRSTNAME"].ToString(), lastname: read["LASTNAME"].ToString(), gender: read["GENDER"].ToString(), email: read["EMAIL"].ToString(), phone: read["PHONE"].ToString(), birthday: Convert.ToDateTime(read["BIRTHDAY"]), specialized: read["SPECIALIZED"].ToString(), lessonPrice: Convert.ToInt32(read["LESSON_COST"]), status: Convert.ToBoolean(read["STATUS"]));
                        if (incPic)
                        {
                            t.Pic = StaticClass.imgManager.ImgbaseToImg(read["PICTURE"].ToString());
                            t.ImgBase = read["PICTURE"].ToString();
                        }
                        trainers.Add(t);
                    }
                    return trainers;
                }
                else
                {
                    Console.WriteLine($"Error! No records found for ID or username '{search}'");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
                return null;
            }
        }

        public Trainer AddTrainer(Trainer trainer)
        {
            try
            {
                string query = $"INSERT INTO ADMINSYSTEM.TRAINER (ID, FIRSTNAME, LASTNAME, GENDER, PICTURE, EMAIL, PHONE, BIRTHDAY, SPECIALIZED, LESSON_COST, STATUS) VALUES (@id, @firstname, @lastname, @birthday, @gender, @picture, @email, @phone, @specialized, @lesson_cost, @status)";
                int rows = StaticClass.sql.MySqlNonQ(query);
                if (rows > 0)
                {
                    Console.WriteLine("Trainer created successfully");
                    return trainer;
                }
                else
                {
                    Console.WriteLine("Error while adding trainer");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while adding in MySQL. {ex.Message}");
                return null;
            }
        }
        public bool UpdateTrainer(Trainer trainer, bool firstname = false, bool lastname = false, bool gender = false, bool birthday = false, bool email = false, bool phone = false, bool pic = false, bool specialized = false, bool lessoncost = false, bool status = false)
        {
            try
            {
                string query = "UPDATE ADMINSYSTEM.TRAINER SET";
                if (firstname) { query += $"FIRSTNAME = '{trainer.FirstName}',"; }
                if (lastname) { query += $"LASTNAME = '{trainer.LastName}',"; }
                if (gender) { query += $"GENDER = '{trainer.Gender}',"; }
                if (birthday) { query += $"BIRTHDAY = '{trainer.Birthday}',"; }

                if (email) { query += $"EMAIL = '{trainer.Email}',"; }
                if (phone) { query += $"PHONE = '{trainer.Phone}',"; }
                if (pic) { query += $"PICTURE = '{trainer.Pic}',"; }

                if (specialized) { query += $"SPECIALIZED = '{trainer.Specialized}',"; }
                if (lessoncost) { query += $"LESSON_COST = '{trainer.LessonPrice}',"; }
                if (status) { query += $"STATUS = '{trainer.Status}',"; }

                if (query == $"UPDATE ADMINSYSTEM.TRAINER SET")
                {
                    Console.WriteLine($"Error while updating! Nothing to update");
                    return false;
                }
                query = query.Substring(0, query.Length - 1);
                query += $"WHERE id = {trainer.Id}";
                int row = StaticClass.sql.MySqlNonQ(query);

                if (row > 0)
                {
                    Console.WriteLine($"Trainer attributes updated successfully for ID: {trainer.Id}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error while updating trainer ID: {trainer.Id}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating trainer! {ex.Message}");
                return false;
            }
        }

        public List<Trainer> AllTrainers(bool status, bool incPic)
        {
            try
            {
                List<Trainer> trainer = new List<Trainer>();
                string query = status ? $"SELECT {GetCol(incPic)} FROM ADMINSYSTEM.TRAINER WHERE status = 1" : $"SELECT {GetCol(incPic)} FROM ADMINSYSTEM.TRAINER";

                MySqlDataReader read = StaticClass.sql.MySqlSelect(query);
                if(read.HasRows)
                {
                    while (read.Read())
                    {
                        Trainer t = new Trainer(id: Convert.ToInt32(read["ID"]), firstname: read["FIRSTNAME"].ToString(), lastname: read["LASTNAME"].ToString(), gender: read["GENDER"].ToString(), email: read["EMAIL"].ToString(), phone: read["PHONE"].ToString(), birthday: Convert.ToDateTime(read["BIRTHDAY"]), specialized: read["SPECIALIZED"].ToString(), lessonPrice: Convert.ToInt32(read["LESSON_COST"]), status: Convert.ToBoolean(read["STATUS"]));
                        if (incPic)
                        {
                            t.Pic = StaticClass.imgManager.ImgbaseToImg(read["PICTURE"].ToString());
                            t.ImgBase = read["PICTURE"].ToString();
                        }
                        trainer.Add(t);
                    }return trainer;
                }
                else
                {
                    Console.WriteLine("Error! No records found");
                    return null;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine($"Error while getting data from MySQL! {ex.Message}");
                return null;
            }
        }
        public int LastID()
        {
            try
            {
                int lastID = 0;
                string query = "SELECT id FROM ADMINSYSTEM.TRAINER ORDER BY id DESC LIMIT 1";
                MySqlDataReader read = StaticClass.sql.MySqlSelect(query);

                if (read.HasRows)
                {
                    read.Read();
                    lastID = Convert.ToInt32(read["ID"]);
                    return lastID;
                }
                else
                {
                    Console.WriteLine("Error! No last id found");
                    return lastID;
                }
            }catch (Exception ex) {
                Console.WriteLine($"Error while getting last trainer id! {ex.Message}");
                return -1;
            }
        }
    }
}