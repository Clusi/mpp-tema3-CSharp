using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Networking
{
    [Serializable]
    class LogInRequest: IRequest
    {
        private AngajatDTO user;

        public LogInRequest(AngajatDTO user)
        {
            this.user = user;
        }

        public virtual AngajatDTO User
        {
            get
            {
                return user;
            }
        }
    }
    [Serializable]
    class GetFlightsRequest : IRequest
    {
       
    }

    [Serializable]
    class SearchFlightsRequest : IRequest
    {
        private string destinatie;
        private string dataPlecare;

        public SearchFlightsRequest(string destinatie, string dataPlecare)
        {
            this.destinatie = destinatie;
            this.dataPlecare = dataPlecare;
        }

        public string Destinatie => destinatie;

        public string DataPlecare => dataPlecare;
    }

    [Serializable]
    class AddBiletRequest : IRequest
    {
        private string client;
        private string turisti;
        private string adresa;
        private int idDestinatie;

        public AddBiletRequest(string client,string turisti, string adresa, int idDestinatie)
        {
            this.client = client;
            this.adresa = adresa;
            this.idDestinatie = idDestinatie;
            this.turisti = turisti;
        }

        public string Client => client;

        public string Adresa => adresa;

        public int IdDestinatie => idDestinatie;

        public string Turisti => turisti;
    }

    [Serializable]
    class FindByIdZborRequest : IRequest
    {
        private int idZbor;

        public FindByIdZborRequest(int idZbor)
        {
            this.idZbor = idZbor;
        }

        public int IdZbor => idZbor;
    }
}
