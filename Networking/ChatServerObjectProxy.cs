using System;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using chat.services;
using lab1.Domain;
using Microsoft.Build.Tasks;
using Networking;
using Services;

namespace chat.network.server
{
	///
	/// <summary> * Created by IntelliJ IDEA.
	/// * User: grigo
	/// * Date: Mar 18, 2009
	/// * Time: 4:36:34 PM </summary>
	/// 
	public class ChatServerProxy : IServicesServer
	{
		private string host;
		private int port;

		private NetworkStream stream;
		
        private IFormatter formatter;
		private TcpClient connection;

		private Queue<IResponse> responses;
		private volatile bool finished;
        private EventWaitHandle _waitHandle;
		public ChatServerProxy(string host, int port)
		{
			this.host = host;
			this.port = port;
			responses=new Queue<IResponse>();
		}

      


		private void closeConnection()
		{
			finished=true;
			try
			{
				stream.Close();
				//output.close();
				connection.Close();
                _waitHandle.Close();
				
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
			}

		}

		private void sendRequest(IRequest request)
		{
			try
			{
                formatter.Serialize(stream, request);
                stream.Flush();
			}
			catch (Exception e)
			{
				throw new ChatException("Error sending object "+e);
			}

		}

		private IResponse readResponse()
		{
			IResponse response =null;
			try
			{
                _waitHandle.WaitOne();
				lock (responses)
				{
                    //Monitor.Wait(responses); 
                    response = responses.Dequeue();
                
				}
				

			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
			}
			return response;
		}
		private void initializeConnection()
		{
			 try
			 {
				connection=new TcpClient(host,port);
				stream=connection.GetStream();
                formatter = new BinaryFormatter();
				finished=false;
                _waitHandle = new AutoResetEvent(false);
				startReader();
			}
			catch (Exception e)
			{
                Console.WriteLine(e.StackTrace);
			}
		}
		private void startReader()
		{
			Thread tw =new Thread(run);
			tw.Start();
		}

		public virtual void run()
			{
				while(!finished)
				{
					try
					{
                        object response = formatter.Deserialize(stream);
					    Console.WriteLine("response received " + response);
						lock (responses)
						    {
                                					
								 
                                responses.Enqueue((IResponse)response);
                               
							}
                            _waitHandle.Set();
					}
					catch (Exception e)
					{
						Console.WriteLine("Reading error "+e);
					}
					
				}
			}

	    public List<Zbor> findByDestinatieDataplecareFlight(string destinatie, string dataPlecare)
	    {
	        List<Zbor> res = new List<Zbor>();
	        sendRequest(new SearchFlightsRequest(destinatie,dataPlecare));
	        IResponse response = readResponse();
	        if (response is SearchFlightsResponse)
	        {
	            SearchFlightsResponse r = (SearchFlightsResponse)response;
	            res = DTOUtils.getFromDTO(r.Flights);
	        }
	        return res;
        }

	    public void addBilet(string client,string turisti, string adresa, int idDestinatie)
	    {
	        sendRequest(new AddBiletRequest(client,turisti,adresa,idDestinatie));
	        IResponse response = readResponse();
	        if (response is AddBiletResponse)
	        {
	            
	        }
        }

	    public List<Zbor> getAllFlight()
	    {
            List<Zbor> res = new List<Zbor>();
            sendRequest(new GetFlightsRequest());
	        IResponse response = readResponse();
	        if (response is GetFlightsResponse)
	        {
	            GetFlightsResponse r =  (GetFlightsResponse) response;
	            res =  DTOUtils.getFromDTO(r.Flights);
	        }
	        return res;
	    }

	    public Zbor findByIdZbor(int id)
	    {
	        Zbor z = null;
            sendRequest(new FindByIdZborRequest(id));
	        IResponse response = readResponse();
	        if (response is FindByIdResponse)
	        {
	            FindByIdResponse r = (FindByIdResponse) response;
	            z = DTOUtils.getFromDTO(r.Zbor);
	        }
	        return z;
	    }

	    public bool logIn(string userName, string password)
	    {
	        initializeConnection();
	        AngajatDTO udto = DTOUtils.getDTO(new Angajat(1, userName, password));
	        sendRequest(new LogInRequest(udto));
	        IResponse response = readResponse();
	        if (response is OkResponse)
	        {
	            //this.client=client;
	            return true;
	        }
	        else
	            return false;

        }
	}

}