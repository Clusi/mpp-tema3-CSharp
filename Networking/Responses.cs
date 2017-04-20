using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    [Serializable]
    class OkResponse: IResponse
    {
    }

    [Serializable]
    class GetFlightsResponse : IResponse
    {
        private List<ZborDTO> flights;

        public GetFlightsResponse(List<ZborDTO> flights)
        {
            this.flights = flights;
        }

        public List<ZborDTO> Flights
        {
            get { return flights; }

        }
    }

    [Serializable]
    class SearchFlightsResponse : IResponse
    {
        private List<ZborDTO> flights;

        public SearchFlightsResponse(List<ZborDTO> flights)
        {
            this.flights = flights;
        }

        public List<ZborDTO> Flights
        {
            get { return flights; }

        }
    }

    [Serializable]
    public class FindByIdResponse : IResponse
    {
        private ZborDTO zbor;

        public FindByIdResponse(ZborDTO zbor)
        {
            this.zbor = zbor;
        }

        public ZborDTO Zbor => zbor;
    }

    [Serializable]
    public class AddBiletResponse : IResponse
    {
       
    }
}
