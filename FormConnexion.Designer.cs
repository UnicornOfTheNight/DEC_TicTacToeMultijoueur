namespace TicTacToe
{
	partial class FormConnexion
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
			this.gbCreerPartie = new System.Windows.Forms.GroupBox();
			this.tbPseudoJ1 = new System.Windows.Forms.TextBox();
			this.lblPseudoJ1 = new System.Windows.Forms.Label();
			this.tbAddrServeur = new System.Windows.Forms.TextBox();
			this.lblAutreAddrServeur = new System.Windows.Forms.Label();
			this.lblAddrLstServeur = new System.Windows.Forms.Label();
			this.lbAddrServeur = new System.Windows.Forms.ListBox();
			this.btCreer = new System.Windows.Forms.Button();
			this.gbRejoindrePartie = new System.Windows.Forms.GroupBox();
			this.lbAddrClient = new System.Windows.Forms.ListBox();
			this.tbPseudoJ2 = new System.Windows.Forms.TextBox();
			this.lblPseudoJ2 = new System.Windows.Forms.Label();
			this.tbAddrClient = new System.Windows.Forms.TextBox();
			this.lblAddrClient = new System.Windows.Forms.Label();
			this.btRejoindre = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gbCreerPartie.SuspendLayout();
			this.gbRejoindrePartie.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbCreerPartie
			// 
			this.gbCreerPartie.BackColor = System.Drawing.Color.Gainsboro;
			this.gbCreerPartie.Controls.Add(this.tbPseudoJ1);
			this.gbCreerPartie.Controls.Add(this.lblPseudoJ1);
			this.gbCreerPartie.Controls.Add(this.tbAddrServeur);
			this.gbCreerPartie.Controls.Add(this.lblAutreAddrServeur);
			this.gbCreerPartie.Controls.Add(this.lblAddrLstServeur);
			this.gbCreerPartie.Controls.Add(this.lbAddrServeur);
			this.gbCreerPartie.Controls.Add(this.btCreer);
			this.gbCreerPartie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCreerPartie.Location = new System.Drawing.Point(12, 28);
			this.gbCreerPartie.Name = "gbCreerPartie";
			this.gbCreerPartie.Size = new System.Drawing.Size(1079, 326);
			this.gbCreerPartie.TabIndex = 0;
			this.gbCreerPartie.TabStop = false;
			this.gbCreerPartie.Text = "Créer une partie";
			// 
			// tbPseudoJ1
			// 
			this.tbPseudoJ1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPseudoJ1.Location = new System.Drawing.Point(557, 201);
			this.tbPseudoJ1.Name = "tbPseudoJ1";
			this.tbPseudoJ1.Size = new System.Drawing.Size(273, 32);
			this.tbPseudoJ1.TabIndex = 6;
			// 
			// lblPseudoJ1
			// 
			this.lblPseudoJ1.AutoSize = true;
			this.lblPseudoJ1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPseudoJ1.Location = new System.Drawing.Point(285, 201);
			this.lblPseudoJ1.Name = "lblPseudoJ1";
			this.lblPseudoJ1.Size = new System.Drawing.Size(217, 23);
			this.lblPseudoJ1.TabIndex = 5;
			this.lblPseudoJ1.Text = "Entrez votre pseudo :";
			// 
			// tbAddrServeur
			// 
			this.tbAddrServeur.Enabled = false;
			this.tbAddrServeur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddrServeur.Location = new System.Drawing.Point(809, 115);
			this.tbAddrServeur.Name = "tbAddrServeur";
			this.tbAddrServeur.Size = new System.Drawing.Size(264, 32);
			this.tbAddrServeur.TabIndex = 4;
			this.tbAddrServeur.Text = "x.x.x.x";
			// 
			// lblAutreAddrServeur
			// 
			this.lblAutreAddrServeur.AutoSize = true;
			this.lblAutreAddrServeur.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAutreAddrServeur.Location = new System.Drawing.Point(6, 120);
			this.lblAutreAddrServeur.Name = "lblAutreAddrServeur";
			this.lblAutreAddrServeur.Size = new System.Drawing.Size(697, 21);
			this.lblAutreAddrServeur.TabIndex = 3;
			this.lblAutreAddrServeur.Text = "Si l\'adresse souhaitée n\'appartait pas, sélectionnez \"Autre\" et indiquez l\'adress" +
    "e ici :";
			// 
			// lblAddrLstServeur
			// 
			this.lblAddrLstServeur.AutoSize = true;
			this.lblAddrLstServeur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddrLstServeur.Location = new System.Drawing.Point(112, 58);
			this.lblAddrLstServeur.Name = "lblAddrLstServeur";
			this.lblAddrLstServeur.Size = new System.Drawing.Size(369, 23);
			this.lblAddrLstServeur.TabIndex = 2;
			this.lblAddrLstServeur.Text = "Choisir une adresse IP pour la partie :";
			// 
			// lbAddrServeur
			// 
			this.lbAddrServeur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddrServeur.FormattingEnabled = true;
			this.lbAddrServeur.ItemHeight = 23;
			this.lbAddrServeur.Location = new System.Drawing.Point(577, 35);
			this.lbAddrServeur.Name = "lbAddrServeur";
			this.lbAddrServeur.Size = new System.Drawing.Size(496, 73);
			this.lbAddrServeur.TabIndex = 1;
			this.lbAddrServeur.SelectedIndexChanged += new System.EventHandler(this.lbAddrServeur_SelectedIndexChanged);
			// 
			// btCreer
			// 
			this.btCreer.BackColor = System.Drawing.Color.White;
			this.btCreer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCreer.Location = new System.Drawing.Point(400, 268);
			this.btCreer.Name = "btCreer";
			this.btCreer.Size = new System.Drawing.Size(229, 38);
			this.btCreer.TabIndex = 0;
			this.btCreer.Text = "Créer la partie";
			this.btCreer.UseVisualStyleBackColor = false;
			this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
			// 
			// gbRejoindrePartie
			// 
			this.gbRejoindrePartie.BackColor = System.Drawing.Color.Gainsboro;
			this.gbRejoindrePartie.Controls.Add(this.label1);
			this.gbRejoindrePartie.Controls.Add(this.lbAddrClient);
			this.gbRejoindrePartie.Controls.Add(this.tbPseudoJ2);
			this.gbRejoindrePartie.Controls.Add(this.lblPseudoJ2);
			this.gbRejoindrePartie.Controls.Add(this.tbAddrClient);
			this.gbRejoindrePartie.Controls.Add(this.lblAddrClient);
			this.gbRejoindrePartie.Controls.Add(this.btRejoindre);
			this.gbRejoindrePartie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRejoindrePartie.Location = new System.Drawing.Point(12, 412);
			this.gbRejoindrePartie.Name = "gbRejoindrePartie";
			this.gbRejoindrePartie.Size = new System.Drawing.Size(1079, 352);
			this.gbRejoindrePartie.TabIndex = 1;
			this.gbRejoindrePartie.TabStop = false;
			this.gbRejoindrePartie.Text = "Rejoindre une partie";
			// 
			// lbAddrClient
			// 
			this.lbAddrClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddrClient.FormattingEnabled = true;
			this.lbAddrClient.ItemHeight = 23;
			this.lbAddrClient.Location = new System.Drawing.Point(488, 52);
			this.lbAddrClient.Name = "lbAddrClient";
			this.lbAddrClient.Size = new System.Drawing.Size(496, 73);
			this.lbAddrClient.TabIndex = 7;
			this.lbAddrClient.SelectedIndexChanged += new System.EventHandler(this.lbAddrClient_SelectedIndexChanged);
			// 
			// tbPseudoJ2
			// 
			this.tbPseudoJ2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPseudoJ2.Location = new System.Drawing.Point(557, 224);
			this.tbPseudoJ2.Name = "tbPseudoJ2";
			this.tbPseudoJ2.Size = new System.Drawing.Size(273, 32);
			this.tbPseudoJ2.TabIndex = 13;
			// 
			// lblPseudoJ2
			// 
			this.lblPseudoJ2.AutoSize = true;
			this.lblPseudoJ2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPseudoJ2.Location = new System.Drawing.Point(285, 227);
			this.lblPseudoJ2.Name = "lblPseudoJ2";
			this.lblPseudoJ2.Size = new System.Drawing.Size(217, 23);
			this.lblPseudoJ2.TabIndex = 12;
			this.lblPseudoJ2.Text = "Entrez votre pseudo :";
			// 
			// tbAddrClient
			// 
			this.tbAddrClient.Enabled = false;
			this.tbAddrClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddrClient.Location = new System.Drawing.Point(809, 131);
			this.tbAddrClient.Name = "tbAddrClient";
			this.tbAddrClient.Size = new System.Drawing.Size(264, 32);
			this.tbAddrClient.TabIndex = 11;
			this.tbAddrClient.Text = "x.x.x.x";
			// 
			// lblAddrClient
			// 
			this.lblAddrClient.AutoSize = true;
			this.lblAddrClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddrClient.Location = new System.Drawing.Point(112, 68);
			this.lblAddrClient.Name = "lblAddrClient";
			this.lblAddrClient.Size = new System.Drawing.Size(351, 23);
			this.lblAddrClient.TabIndex = 9;
			this.lblAddrClient.Text = "Adresse IP de la partie à rejoindre :";
			// 
			// btRejoindre
			// 
			this.btRejoindre.BackColor = System.Drawing.Color.White;
			this.btRejoindre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRejoindre.Location = new System.Drawing.Point(400, 289);
			this.btRejoindre.Name = "btRejoindre";
			this.btRejoindre.Size = new System.Drawing.Size(229, 38);
			this.btRejoindre.TabIndex = 7;
			this.btRejoindre.Text = "Rejoindre la partie";
			this.btRejoindre.UseVisualStyleBackColor = false;
			this.btRejoindre.Click += new System.EventHandler(this.btRejoindre_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(697, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "Si l\'adresse souhaitée n\'appartait pas, sélectionnez \"Autre\" et indiquez l\'adress" +
    "e ici :";
			// 
			// FormConnexion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1105, 793);
			this.Controls.Add(this.gbRejoindrePartie);
			this.Controls.Add(this.gbCreerPartie);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormConnexion";
			this.Text = "TIC-TAC-TOE";
			this.gbCreerPartie.ResumeLayout(false);
			this.gbCreerPartie.PerformLayout();
			this.gbRejoindrePartie.ResumeLayout(false);
			this.gbRejoindrePartie.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbCreerPartie;
		private System.Windows.Forms.GroupBox gbRejoindrePartie;
		private System.Windows.Forms.Label lblAddrLstServeur;
		private System.Windows.Forms.ListBox lbAddrServeur;
		private System.Windows.Forms.Button btCreer;
		private System.Windows.Forms.Label lblAutreAddrServeur;
		private System.Windows.Forms.TextBox tbAddrServeur;
		private System.Windows.Forms.TextBox tbPseudoJ1;
		private System.Windows.Forms.Label lblPseudoJ1;
		private System.Windows.Forms.TextBox tbPseudoJ2;
		private System.Windows.Forms.Label lblPseudoJ2;
		private System.Windows.Forms.TextBox tbAddrClient;
		private System.Windows.Forms.Label lblAddrClient;
		private System.Windows.Forms.Button btRejoindre;
		private System.Windows.Forms.ListBox lbAddrClient;
		private System.Windows.Forms.Label label1;
	}
}

