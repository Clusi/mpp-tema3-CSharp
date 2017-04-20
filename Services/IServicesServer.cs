using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Domain;

namespace Services
{
    public interface IServicesServer
    {
        List<Zbor> findByDestinatieDataplecareFlight(string destinatie, string dataPlecare);
        void addBilet(string client,string turisti, string adresa, int idDestinatie);
        List<Zbor> getAllFlight();
        Zbor findByIdZbor(int id);
        bool logIn(string userName, string password);
    }
}
