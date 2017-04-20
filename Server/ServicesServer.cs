using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Domain;
using lab1.Repository;
using Persistence.Repository;
using Services;

namespace Server
{
    class ServicesServer :IServicesServer
    {

        private RepositoryBilet repositoryBilet;
        private RepositoryZbor repositoryZbor;
        private RepositoryAngajat repositoryAngajat;

        public ServicesServer(RepositoryBilet repositoryBilet, RepositoryZbor repositoryZbor,RepositoryAngajat repositoryAngajat)
        {
            this.repositoryZbor = repositoryZbor;
            this.repositoryBilet = repositoryBilet;
            this.repositoryAngajat = repositoryAngajat;
           
        }

        public List<Zbor> findByDestinatieDataplecareFlight(string destinatie, string dataPlecare)
        {
            return repositoryZbor.finByDestinatieDataPlecare(destinatie, dataPlecare);
        }

        public void addBilet(string client,string turisti,string adresa, int idDestinatie)
        {
            add(client,adresa,idDestinatie);
            if (!turisti.Equals(""))
            {
                string[] t = turisti.Split(' ');
                foreach (string s in t)
                {
                   add(s, adresa, idDestinatie);
                }
            }
        }

        public void add(string client, string adresa, int idDestinatie)
        {
            Zbor zbor = repositoryZbor.findById(idDestinatie);
            repositoryBilet.add(new Bilet(1, client, adresa, idDestinatie));
            zbor.NrLocuriDisponibile = zbor.NrLocuriDisponibile - 1;
            repositoryZbor.update(zbor, idDestinatie);
        }

        public List<Zbor> getAllFlight()
        {
            List<Zbor> res = new List<Zbor>();
            foreach (Zbor z in repositoryZbor.getAll())
                if (z.NrLocuriDisponibile > 0) res.Add(z);
            return res;
        }

        public Zbor findByIdZbor(int id)
        {
            return repositoryZbor.findById(id);
        }

        public bool logIn(string userName, string password)
        {
          
            return repositoryAngajat.logare(userName, password);
        }
    }
}
