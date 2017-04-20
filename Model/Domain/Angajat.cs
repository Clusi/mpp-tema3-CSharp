using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Domain
{
    public class Angajat
    {
        private int id;
        private string user;
        private string parola;

        public Angajat(int id, string user, string parola)
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
}
