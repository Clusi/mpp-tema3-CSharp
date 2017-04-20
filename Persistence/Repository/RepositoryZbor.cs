using lab1.Domain;

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Repository
{
    public class RepositoryZbor:IRepository<Zbor>
    {
        private SQLiteConnection conn;
        

        public RepositoryZbor(string url)
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

        public void add(Zbor e)
        {
            try
            {
                string sqlComand = "Insert into Zbor (destinatie,dataPlecare,oraPlecare,aeroport,nrLocuriDisponibile) values(\"" + e.Destinatie + "\",\"" + e.DataOraPlecare.ToString("yyyy-MM-dd") + "\",\"" + e.DataOraPlecare.ToString("HH:mm:ss") + "\",\"" + e.Aeroport + "\"," + e.NrLocuriDisponibile + ")";
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
        public Zbor findById(int id)
        {
            try
            {
                string sqlComand = "SELECT * FROM Zbor WHERE id=" + id;
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = sqlComand;
                var reader = cmd.ExecuteReader();
                reader.Read();
                int idZ = Convert.ToInt32(reader["id"]);
                string destinatie = reader["destinatie"].ToString();

                string dataPlecare = reader["dataPlecare"].ToString().Split(' ')[0];
                string oraPlecare = reader["oraPlecare"].ToString().Split(' ')[1];
                string aeroport = reader["aeroport"].ToString();
                int nrLocuriDisponibile = Convert.ToInt32(reader["nrLocuriDisponibile"]);

                string[] d = dataPlecare.Split('/');
                string[] o = oraPlecare.Split(':');
                DateTime dt = new DateTime(Int32.Parse(d[2]), Int32.Parse(d[1]), Int32.Parse(d[0]),
                    Int32.Parse(o[0]), Int32.Parse(o[1]), Int32.Parse(o[2]));
                reader.Close();
                conn.Close();
                return new Zbor(idZ, destinatie, dt, aeroport, nrLocuriDisponibile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public List<Zbor> finByDestinatieDataPlecare(string dest,string dataP)
        {
            List<Zbor> res = new List<Zbor>();
            string sqlComand = "Select * from Zbor WHERE destinatie='"+dest+"' AND dataPlecare='"+dataP+"'";
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = sqlComand;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string destinatie = reader["destinatie"].ToString();

                string dataPlecare = reader["dataPlecare"].ToString().Split(' ')[0];
                string oraPlecare = reader["oraPlecare"].ToString().Split(' ')[1];
                string aeroport = reader["aeroport"].ToString();
                int nrLocuriDisponibile = Convert.ToInt32(reader["nrLocuriDisponibile"]);

                string[] d = dataPlecare.Split('/');
                string[] o = oraPlecare.Split(':');
                DateTime dt = new DateTime(Int32.Parse(d[2]), Int32.Parse(d[1]), Int32.Parse(d[0]),
               Int32.Parse(o[0]), Int32.Parse(o[1]), Int32.Parse(o[2]));

                res.Add(new Zbor(id, destinatie, dt, aeroport, nrLocuriDisponibile));
            }
            conn.Close();
            return res;
        }

        public void delete(int id)
        {
            try
            {
                string sqlComand = "DELETE FROM Bilet where id=" + id;
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

        public List<Zbor> getAll()
        {
            List<Zbor> res = new List<Zbor>();
            try
            {
                string sqlComand = "SELECT * FROM Zbor";
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sqlComand;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //destinatie,dataPlecare,oraPlecare,aeroport,nrLocuriDisponibile
                            int id = Convert.ToInt32(reader["id"]);
                            string destinatie = reader["destinatie"].ToString();
                            
                            string dataPlecare = reader["dataPlecare"].ToString().Split(' ')[0];
                            string oraPlecare = reader["oraPlecare"].ToString().Split(' ')[1];
                            string aeroport = reader["aeroport"].ToString();
                            int nrLocuriDisponibile = Convert.ToInt32(reader["nrLocuriDisponibile"]);

                            string []d = dataPlecare.Split('/');
                            string[] o = oraPlecare.Split(':');
                             DateTime dt = new DateTime(Int32.Parse(d[2]), Int32.Parse(d[1]), Int32.Parse(d[0]),
                            Int32.Parse(o[0]), Int32.Parse(o[1]), Int32.Parse(o[2]));
                            
                            res.Add(new Zbor(id, destinatie, dt, aeroport, nrLocuriDisponibile));


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
            //Console.WriteLine(res.Count);
            return res;
        }
       

        public void update(Zbor e, int id)
        {
            try
            {
                //destinatie,dataPlecare,oraPlecare,aeroport,nrLocuriDisponibile
                string sqlComand = "UPDATE Zbor set nrLocuriDisponibile=" + e.NrLocuriDisponibile + " where id=" + id;
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

