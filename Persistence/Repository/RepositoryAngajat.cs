using System;
using System.Collections.Generic;
using System.Data.SQLite;
using lab1.Domain;
using lab1.Repository;

namespace Persistence.Repository
{
    public class RepositoryAngajat:IRepository<Angajat>
    {
        private SQLiteConnection conn;
        public RepositoryAngajat(string url)
        {
            try
            {
                this.conn = new SQLiteConnection(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        public void add(Angajat e)
        {
            try
            {
                string sqlComand = "Insert into Angajat (user,parola) values(\"" + e.User + "\",\"" + e.Parola + "\",\"" + ")";
                conn.Open();
                var cmd = new SQLiteCommand(sqlComand, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void delete(int id)
        {
            try
            {
                string sqlComand = "DELETE FROM Angajat where id=" + id;
                conn.Open();
                var cmd = new SQLiteCommand(sqlComand, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Angajat> getAll()
        {
            List<Angajat> res = new List<Angajat>();
            try
            {
                string sqlComand = "SELECT * FROM Angajat";
                conn.Open();
                using (var cmd = conn.CreateCommand())

                {
                    cmd.CommandText = sqlComand;
                    using (var reader = cmd.ExecuteReader())
                    {



                        while (reader.Read())
                        {
                            
                            
                            string user = reader["user"].ToString();
                            string parola = reader["parola"].ToString();
                            int id = Convert.ToInt32(reader["id"]);


                            res.Add(new Angajat(id, user,parola));

                        }

                        reader.Close();
                        conn.Close();
                    }
                }
            }



            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }

        public void update(Angajat e, int id)
        {
            try
            {
                string sqlComand = "UPDATE Angajat set user=\"" + e.User + "\", parola=\"" + e.Parola +" \"where id=" + id;
                conn.Open();
                var cmd = new SQLiteCommand(sqlComand, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool logare(string user, string parola)
        {
            Boolean ok = false;
            try
            {
                string sqlComand = "SELECT * FROM Angajat WHERE user=\""+user +"\"and parola=\""+parola+"\"";
                conn.Open();
                using (var cmd = conn.CreateCommand())

                {
                    cmd.CommandText = sqlComand;
                    using (var reader = cmd.ExecuteReader())

                    {
                        if (reader.Read())
                            ok = true;
                    }
                        conn.Close();
                 }
             }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ok;

        }
    }

   
}

