using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using chat.network.client;
using lab1.Repository;
using Persistence.Repository;
using ServerTemplate;
using Services;

namespace Server
{
    class StartServer
    {
        [STAThread]
        static void Main()
        {

            String connectionString = @"Data Source= D:\an 2 semestru 2\mpp\tema1-java\AgentieTurism.db; Version = 3";
            RepositoryAngajat repositoryAngajat = new RepositoryAngajat(connectionString);
            RepositoryBilet repositoryBilet = new RepositoryBilet(connectionString);
            RepositoryZbor repositoryZbor = new RepositoryZbor(connectionString);
            ServicesServer ctrlServicesServer = new ServicesServer(repositoryBilet, repositoryZbor, repositoryAngajat);
           

            
            SerialChatServer server = new SerialChatServer("127.0.0.1", 55555, ctrlServicesServer);
            server.Start();
            Console.WriteLine("Server started ...");
            //Console.WriteLine("Press <enter> to exit...");
            Console.ReadLine();

        }
    }

    public class SerialChatServer : ConcurrentServer
    {
        private IServicesServer server;
        private ChatClientWorker worker;
        public SerialChatServer(string host, int port, IServicesServer server) : base(host, port)
        {
            this.server = server;
            Console.WriteLine("SerialChatServer...");
        }
        protected override Thread createWorker(TcpClient client)
        {
            worker = new ChatClientWorker(server, client);
            return new Thread(new ThreadStart(worker.run));
        }
    }
}

