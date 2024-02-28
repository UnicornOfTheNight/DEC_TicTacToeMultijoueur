using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class FormJeux : Form
	{
		Button bt; //boutton qui va prendre le bt cliqué
		int[] tab; //tableau pour retenir le score de la ligne
		int valeur; //valeur de la case pour le joueur
		string joueur, opposant; //nom et score des joueurs
		char mode; //s = serveur et c = client
		char caractere; // caractere du joueur (O ou X)
		char caractereOppose; //caractere du joueur adverse
		int score; //nb de parties gagnées par le joueur
		int scoreAdversaire; //nb de parties gagnées par l'adversaire

		Socket sktClient, sktServeur;
		IPAddress ipAddr;
		IPEndPoint ipEndPt;


		delegate void Jouer(string p_nomBt);
		
		public FormJeux(string p_nomJoueur, char p_mode, IPAddress p_ipAddr, IPEndPoint p_ipEndPt)
		{
			InitializeComponent();
			bt = new Button();
			tab = new int[8];
			score = 0;
			scoreAdversaire = 0;

			ipAddr = p_ipAddr;
			ipEndPt = p_ipEndPt;

			mode = p_mode;

			if(mode == 'c') //si on est en mode client
			{
				caractere = 'O';
				caractereOppose = 'X';
				valeur = 3;
				opposant = "";
				joueur = p_nomJoueur;

				sktClient = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				sktClient.Connect(ipEndPt);

				StateObject state = new StateObject();
				state.workSocket = sktClient;

				sktClient.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), state);

				byte[] nom = Encoding.Unicode.GetBytes(joueur);
				int bytesSend = sktClient.Send(nom); 
			}
			else if(mode == 's')
			{
				caractere = 'X';
				caractereOppose = 'O';
				valeur = 5;
				joueur = p_nomJoueur;
				opposant = "";

				sktServeur = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				sktServeur.Bind(ipEndPt);

				sktServeur.Listen(1);
				sktServeur.BeginAccept(new AsyncCallback(AcceptCallback), sktServeur);
			}
		}

		private void AcceptCallback(IAsyncResult ar)
		{
			Socket handler = (Socket)ar.AsyncState;
			sktClient = handler.EndAccept(ar);

			StateObject state = new StateObject();
			state.workSocket = sktClient;

			sktClient.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), state);
			
			byte[] nom = Encoding.Unicode.GetBytes(joueur);
			int bytesSend = sktClient.Send(nom);
		}

		public void RemplirBt(string p_nomBt)
		{
			foreach (Button item in Controls.OfType<Button>()) //on parcours tous les boutons de la forme
			{
				if (item.Name == p_nomBt) //si le bouton correspond a celui qui a été cliqué on le sauvegarde
				{
					bt = item;
				}
			}

			bt.Text = caractereOppose.ToString();
			bt.Enabled = false;

			foreach (Button item in Controls.OfType<Button>()) //on autorise l'utilisateur a jouer
			{
				if (item.Text == "")
				{
					item.Enabled = true;
				}
			}
		}

		/// <summary>
		/// Incrémente le tableau pour avoir la somme de chaque ligne / diagonale
		/// </summary>
		/// <param name="p_nomBt"></param>
		private void IncrementerTab(string p_nomBt)
		{
			int indexBt = Convert.ToInt32(p_nomBt.Split('_')[1]); //on récupere le numero du boutton qui a été cliqué
			/*
			 *							diagonale => index 0
			 *          |         |          => index 1
			 * ----------------------------
			 *          |         |          => index 2
			 * ----------------------------
			 *          |         |          => index 3
			 *							diagonale => index 4
			 *  index 7   index 6   index 5
			 */
			switch (indexBt)
			{
				case 1:
					tab[1] += valeur;
					tab[4] += valeur;
					tab[7] += valeur;
					break;

				case 2:
					tab[1] += valeur;
					tab[6] += valeur;
					break;

				case 3:
					tab[0] += valeur;
					tab[1] += valeur;
					tab[3] += valeur;
					break;

				case 4:
					tab[2] += valeur;
					tab[7] += valeur;
					break;

				case 5:
					tab[0] += valeur;
					tab[2] += valeur;
					tab[4] += valeur;
					tab[6] += valeur;
					break;

				case 6:
					tab[2] += valeur;
					tab[5] += valeur;
					break;

				case 7:
					tab[0] += valeur;
					tab[3] += valeur;
					tab[7] += valeur;
					break;

				case 8:
					tab[3] += valeur;
					tab[6] += valeur;
					break;

				case 9:
					tab[3] += valeur;
					tab[4] += valeur;
					tab[5] +=valeur;
					break;
			}

			VerifierFinPartie(); //On vérifie si la partie est finie
		}

		private void VerifierFinPartie()
		{
			bool fin = false;
			int nbRemplis = 0;

			foreach (Button item in Controls.OfType<Button>()) //on parcours le tableau pour voir si match nul
			{
				if (item.Text != "" && item.Name != "bt_Quitter") nbRemplis++;
			}

			for (int i = 0; i < tab.Length; i++) //on parcours le tableau pour voir si quelqu'un a gagné
			{
				if (tab[i] == valeur * 3) //si la valeur est égale à 3 fois la valuer d'une case du joueur, c'est qu'il a fait une ligne
				{
					fin = true;
				}
			}

			if (fin || nbRemplis == 9)
			{
				MessageBox.Show("Partie terminée !");
				if(fin) score++; //si la partie a été gagnée et non match nul on incremente le score

				foreach (Button item in Controls.OfType<Button>()) //on remet tous les boutons a zero
				{
					if(item.Name != "bt_Quitter")
					{
						item.Text = "";
						item.Enabled = true;
					}					
				}

				for (int i = 0; i < tab.Length; i++)//on reinitialise le tableau
				{
					tab[i] = 0;
				}

				lblJoueurs.Invoke(new MethodInvoker(delegate
				{
					lblJoueurs.Text = "Scores : \r\n" + joueur + " : " + score + " - " + opposant + " : " + scoreAdversaire;
				}));

				byte[] sc = Encoding.Unicode.GetBytes("FIN:" + score); //on envoie le message de fin en transmettant le score
				sktClient.Send(sc);
			}
		}

		/// <summary>
		/// Evenement pour tous les boutons du morpion
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bt_Click(object sender, EventArgs e) {
			bt = sender as Button;
			byte[] nom = Encoding.Unicode.GetBytes(bt.Name);

			try
			{
				sktClient.Send(nom);

				bt.Text = caractere.ToString();
				bt.Enabled = false;
				IncrementerTab(bt.Name);

				foreach (Button item in Controls.OfType<Button>()) //on empeche l'utilisateur de jouer plusieurs fois d'affilée
				{
					if(item.Name != "bt_Quitter") item.Enabled = false;
				}
			}
			catch (Exception ex) {
				MessageBox.Show("ERREUR : " + ex.Message);
			}
			
		}

		private void ReceiveCallback(IAsyncResult ar)
		{
			StateObject state = (StateObject)ar.AsyncState;
			Socket handler = state.workSocket;
			int read = handler.EndReceive(ar);

			if (read > 0)
			{				
				state.sb.Append(Encoding.Unicode.GetString(state.buffer, 0, read));

				if (state.sb.Length >= 1)
				{
					string msg = state.sb.ToString();
					
					if (msg.StartsWith("FIN"))
					{
						MessageBox.Show("Partie terminée !");

						scoreAdversaire = Convert.ToInt32(msg.Split(':')[1]);
						lblJoueurs.Invoke(new MethodInvoker(delegate
						{
							lblJoueurs.Text = "Scores : \r\n" + joueur + " : " + score + " - " + opposant + " : " + scoreAdversaire;
						}));


						foreach (Button item in Controls.OfType<Button>()) //on remet tous les boutons a zero
						{
							if(item.Name != "bt_Quitter") {
								item.Text = "";
								item.Enabled = true; 
							}
						}

						for (int i = 0; i < tab.Length; i++)//on reinitialise le tableau
						{
							tab[i] = 0;
						}
					}
					else if (!msg.StartsWith("bt_")) //si le message passé est le nom des joueurs
					{
						opposant = msg;

						lblJoueurs.Invoke(new MethodInvoker(delegate
						{
							lblJoueurs.Text = "Scores : \r\n" + joueur + " : " + score + " - " + opposant + " : " + scoreAdversaire;
						}));
					}
					else //sinon c'est le nom du boutton qui est passé
					{
						bt_1.Invoke(new Jouer(RemplirBt), msg);
					}
				}
				
				state.sb.Clear();
				handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
			}
			else
			{
				handler.Close();
			}
		}

		private void bt_Quitter_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormJeux_Load(object sender, EventArgs e)
		{

		}

		private void FormJeux_FormClosing(object sender, FormClosingEventArgs e)
		{
			EcrireFichier();

			if (sktClient != null && sktClient.Connected)
			{
				sktClient.Shutdown(SocketShutdown.Receive);
				sktClient.Disconnect(false);
			}

			if (sktClient != null)
			{
				sktClient.Close();
				sktClient.Dispose();
			}
		}

		private void EcrireFichier()
		{
			string date = DateTime.Now.ToString();
			string str = date + " = " + joueur + " : " + score + " - " + opposant + " : " + scoreAdversaire;
			StreamWriter fichier = new StreamWriter("parties.txt", true);
			fichier.WriteLine(str);
			fichier.Close();
		}
	}
}
