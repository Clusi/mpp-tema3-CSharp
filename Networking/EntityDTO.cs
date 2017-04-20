using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    [Serializable]
   public class AngajatDTO
    {
        private int id;
        private string user;
        private string parola;

        public AngajatDTO(int id, string user, string parola)
        {
            this.id = id;
            this.user = user;
            this.parola = parola;
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Parola
        {
            get
            {
                return parola;
            }

            set
            {
                parola = value;
            }
        }
    
}
    [Serializable]

    public class ZborDTO
    {
        private int id;
        private string destinatie;
        private DateTime dataOraPlecare;
        // private Time oraPlecare;
        private string aeroport;
        private int nrLocuriDisponibile;

        public ZborDTO(int id, string destinatie, DateTime dataOraPlecare, string aeroport, int nrLocuriDisponibile)
        {
            this.id = id;
            this.destinatie = destinatie;
            this.DataOraPlecare = dataOraPlecare;
            this.aeroport = aeroport;
            this.nrLocuriDisponibile = nrLocuriDisponibile;
        }



        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Destinatie
        {
            get
            {
                return destinatie;
            }

            set
            {
                destinatie = value;
            }
        }



        public string Aeroport
        {
            get
            {
                return aeroport;
            }

            set
            {
                aeroport = value;
            }
        }

        public int NrLocuriDisponibile
        {
            get
            {
                return nrLocuriDisponibile;
            }

            set
            {
                nrLocuriDisponibile = value;
            }
        }

        public DateTime DataOraPlecare
        {
            get
            {
                return dataOraPlecare;
            }

            set
            {
                dataOraPlecare = value;
            }
        }

    }
}
