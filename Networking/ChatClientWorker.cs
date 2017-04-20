using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


using lab1.Domain;
using Networking;
using Services;
namespace chat.network.client
{

	
	
	///
	/// <summary> * Created by IntelliJ IDEA.
	/// * User: grigo
	/// * Date: Mar 18, 2009
	/// * Time: 4:04:43 PM </summary>
	/// 
	public class ChatClientWorker //, Runnable
	{
		private IServicesServer server;
		private TcpClient connection;

		private NetworkStream stream;
		private IFormatter formatter;
		private volatile bool connected;
		public ChatClientWorker(IServicesServer server, TcpClient connection)
		{
			this.server = server;
			this.connection = connection;
			try
			{
				
				stream=connection.GetStream();
                formatter = new BinaryFormatter();
				connected=true;
			}
			catch (Exception e)
			{
                Console.WriteLine(e.StackTrace);
			}
		}

		public virtual void run()
		{
			while(connected)
			{
				try
				{
                    object request = formatter.Deserialize(stream);
					object response =handleRequest((IRequest)request);
					if (response!=null)
					{
					   sendResponse((IResponse) response);
					}
				}
				catch (Exception e)
				{
                    Console.WriteLine(e.StackTrace);
				}
				
				try
				{
					Thread.Sleep(1000);
				}
				catch (Exception e)
				{
                    Console.WriteLine(e.StackTrace);
				}
			}
			try
			{
				stream.Close();
				connection.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Error "+e);
			}
		}
		

	

		private IResponse handleRequest(IRequest request)
		{
		    IResponse response =null;
			if (request is LogInRequest)
			{
				Console.WriteLine("Login request ...");
				LogInRequest logReq =(LogInRequest)request;
				AngajatDTO udto =logReq.User;
				Angajat user =DTOUtils.getFromDTO(udto);
				try
                {

                    lock (server)
                    {
                       bool ok = server.logIn(user.User, user.Parola);
                       if (ok == true)
                           return new OkResponse();
                       else 
                            return new ErrorResponse("log in error");

                    }
                   
				}
				catch (Exception e)
				{
					connected=false;
					return new ErrorResponse(e.Message);
				}
			}
			
			return response;
		}

	private void sendResponse(IResponse response)
		{
			Console.WriteLine("sending response "+response);
            formatter.Serialize(stream, response);
            stream.Flush();
			
		}
	}

}