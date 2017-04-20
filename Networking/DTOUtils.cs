using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab1.Domain;

namespace Networking
{
    class DTOUtils
    {
        
            public static Angajat getFromDTO(AngajatDTO usdto)
            {
                int id = usdto.Id;
                string password = usdto.Parola;
                string user = usdto.User;
                return new Angajat(id, user, password);

            }
            public static AngajatDTO getDTO(Angajat user)
            {
                int id = user.Id;
                string password = user.Parola;
                string userName = user.User;
                return new AngajatDTO(id, userName, password);
            }

        public static List<ZborDTO> getDTO(List<Zbor> flightsDTO)
        {
            List<ZborDTO> flights = new List<ZborDTO>();
            foreach (Zbor f in flightsDTO)
            {
                flights.Add(new ZborDTO(f.Id, f.Destinatie, f.DataOraPlecare, f.Aeroport, f.NrLocuriDisponibile));
            }

            return flights;
        }

        public static List<Zbor> getFromDTO(List<ZborDTO> flightsDTO )
        {
            List<Zbor> flights = new List<Zbor>();
            foreach (ZborDTO f in flightsDTO)
            {
                flights.Add(new Zbor(f.Id, f.Destinatie, f.DataOraPlecare, f.Aeroport, f.NrLocuriDisponibile));
            }
         
            return flights;
        }

        public static ZborDTO getDTO(Zbor zbor)
        {
            return new ZborDTO(zbor.Id,zbor.Destinatie,zbor.DataOraPlecare,zbor.Aeroport,zbor.NrLocuriDisponibile);
        }

        public static Zbor getFromDTO(ZborDTO zbor)
        {
            return new Zbor(zbor.Id, zbor.Destinatie, zbor.DataOraPlecare, zbor.Aeroport, zbor.NrLocuriDisponibile);
        }


    }

}
