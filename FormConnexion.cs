using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class FormConnexion : Form
	{
		IPAddress ipAddr;
		IPEndPoint ipEndPt;

		string nom = ""; 

		public FormConnexion()
		{
			InitializeComponent();

			//on recupere les adressses IP de l'ordinateur
			IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork) //si l'adresse ip est correcte on l'ajoute à la liste
				{
					lbAddrServeur.Items.Add(ip.ToString());
					lbAddrClient.Items.Add(ip.ToString());
				}
			}
			lbAddrServeur.Items.Add("Autre");
			lbAddrClient.Items.Add("Autre");
		}

		private void lbAddrServeur_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lbAddrServeur.SelectedItem.ToString() == "Autre")
			{
				tbAddrServeur.Enabled = true;
				ipAddr = null;
			}
			else
			{
				tbAddrServeur.Enabled = false;
				ipAddr = IPAddress.Parse(lbAddrServeur.SelectedItem.ToString());
			}
		}

		private void lbAddrClient_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbAddrClient.SelectedItem.ToString() == "Autre")
			{
				tbAddrClient.Enabled = true;
				ipAddr = null;
			}
			else
			{
				tbAddrClient.Enabled = false;
				ipAddr = IPAddress.Parse(lbAddrClient.SelectedItem.ToString());
			}
		}

		private void btCreer_Click(object sender, EventArgs e)
		{
			nom = tbPseudoJ1.Text;
			try //on essaie de se connecter pour ouvrir une autre form
			{
				if (ipAddr == null)
				{
					ipAddr = IPAddress.Parse(tbAddrServeur.Text);
				}

				ipEndPt = new IPEndPoint(ipAddr, 4510);			

				Hide();

				FormJeux f2 = new FormJeux(nom, 's', ipAddr, ipEndPt);  
				f2.ShowDialog();	
			}catch(Exception ex)
			{
				MessageBox.Show("ERREUR : " + ex.ToString());
			}
					
		}

		private void btRejoindre_Click(object sender, EventArgs e)
		{
			nom = tbPseudoJ2.Text;

			try //on essaie de se connecter pour ouvrir une autre form
			{
				if (ipAddr == null)
				{
					ipAddr = IPAddress.Parse(tbAddrClient.Text);
				}
				ipEndPt = new IPEndPoint(ipAddr, 4510);

				Hide();

				FormJeux f2 = new FormJeux(nom, 'c', ipAddr, ipEndPt);
				f2.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERREUR : " + ex.ToString());
			}
		}


	}
}
