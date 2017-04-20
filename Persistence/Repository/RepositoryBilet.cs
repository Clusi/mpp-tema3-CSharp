using lab1.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Repository
{

    public class RepositoryBilet : IRepository<Bilet>
    {

        private SQLiteConnection conn;
        public RepositoryBilet (string url)
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
        public void add(Bilet e)
        {
            try
            {
                string sqlComand = "Insert into Bilet (client, adresa, idDestinatie) values('" + e.Client + "','"+e.Adresa + "'," + e.IdDestinatie + ");";
                conn.Open();
                Console.WriteLine("Insert into Bilet(client, adresa, idDestinatie) values('" + e.Client + "', '"+e.Adresa + "', " + e.IdDestinatie + ")");
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
                string sqlComand = "DELETE FROM Bilet where id="+id;
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

        public List<Bilet> getAll()
        {
            List<Bilet> res = new List<Bilet>();
            try
            {
                string sqlComand = "SELECT * FROM Bilet";
                conn.Open();
                using (var cmd = conn.CreateCommand())

                {
                    cmd.CommandText = sqlComand;
                    using (var reader = cmd.ExecuteReader())
                    {



                        while (reader.Read())
                        {
                            //client, adresa, turisti, nrLocuri, idDestinatie
                            int id = Convert.ToInt32(reader["id"]);
                            string client = reader["client"].ToString();
                            string adresa = reader["adresa"].ToString();
                          
                            int idDestinatie = Convert.ToInt32(reader["idDestinatie"]);

                            
                            res.Add(new Bilet(id, client, adresa, idDestinatie));

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

        public void update(Bilet e, int id)
        {
            try
            {
                string sqlComand = "UPDATE Bilet set client="+e.Client+", adresa="+e.Adresa+", idDestinatie="+e.IdDestinatie+" where id="+id;
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
    }
}
