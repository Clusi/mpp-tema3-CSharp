using lab1.Domain;
using lab1.Repository;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace lab1
{
    public partial class Form1 : Form
    {
        private IServicesServer servicesServer;
        public Form1(IServicesServer servicesServer)
        {
            this.servicesServer = servicesServer;
            InitializeComponent();

        }
        
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUserName.Text != "")
            {
                if (servicesServer.logIn(txtUserName.Text, txtPassword.Text))
                {
                    Form2 secondForm = new Form2(servicesServer);
                    secondForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid user or password!");
                
            }
            else
                MessageBox.Show("Empty fields!");
            
        }

      
    }
}
