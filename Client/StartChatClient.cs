using System;
using System.Windows.Forms;
using chat.network.server;
using lab1;
using Services;


namespace Client
{
    static class StartChatClient
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
           
            //IChatServer server=new ChatServerMock();          
            IServicesServer server = new ChatServerProxy("127.0.0.1", 55555);

            
            Form1 win=new Form1(server);
            Application.Run(win);
        }
    }
}
