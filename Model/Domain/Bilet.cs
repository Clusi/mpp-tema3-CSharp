using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Domain
{
    public class Bilet
    {
        private int id;
        private string client;
        private string adresa;
        
        private int idDestinatie;
        
        public Bilet(int id, string client, string adresa,  int idDestinatie)
        {
            this.id = id;
            this.client = client;
            this.adresa = adresa;
            
            this.idDestinatie = idDestinatie;
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

        public string Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        

        public int IdDestinatie
        {
            get
            {
                return idDestinatie;
            }

            set
            {
                idDestinatie = value;
            }
        }
    }
}
