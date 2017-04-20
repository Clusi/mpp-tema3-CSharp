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
    public partial class Form2 : Form
    {
        
        List<Zbor> flyings;
        IServicesServer servicesServer;
        BindingSource bsZbor = new BindingSource();
        public Form2(IServicesServer servicesServer)
        {
            InitializeComponent();

            this.servicesServer = servicesServer;
           // flyings = services.getAllFlight();
            bsZbor.DataSource = flyings;
            dataGridViewZbor.DataSource =bsZbor;
          
        }
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logInForm = new Form1(servicesServer);
            logInForm.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // bsZbor.DataSource = services.findByDestinatieDataplecareFlight(txtDestinatie.Text, txtDataPlecare.Text);

        }

        public void update()
        {
            //bsZbor.DataSource = services.getAllFlight();
        }

        private void btnAddBilet_Click(object sender, EventArgs e)
        {
               /* int nrLocuri;
                try
                {
                    nrLocuri = int.Parse(txtNumarLocuri.Text);

                }catch(Exception ex)
                {
                MessageBox.Show("Numarul de locuri trebuie sa fie int zapacito!");
                return;
                }

                string numeClient = txtNumeClient.Text;
                string adresa = txtAdresa.Text;
                string turisti = txtTuristi.Text;
                int idDestinatie = (int)dataGridViewZbor.Rows[dataGridViewZbor.SelectedCells[0].RowIndex].Cells[0].Value;
                if (!numeClient.Equals("") && !adresa.Equals("")){
                    if (services.findByIdZbor(idDestinatie).NrLocuriDisponibile >= nrLocuri)
                    {
                    services.addBilet(numeClient, adresa, idDestinatie);
                    if (!turisti.Equals(""))
                        {
                            string[] t = turisti.Split(' ');
                            foreach (string s in t)
                            {
                                services.addBilet(s, adresa, idDestinatie);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Not enough seats!");
                }
                else
                    MessageBox.Show("Invalid dates!");*/
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            update();
            txtNumarLocuri.Text = "";
            txtDestinatie.Text = "";
            txtNumeClient.Text = "";
            txtAdresa.Text = "";
            txtTuristi.Text = "";
            txtDataPlecare.Text = "";
        }
    }
}
