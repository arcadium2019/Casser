namespace SAE_S2_Puissance_4
{
    partial class FormLancement
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnParametres = new System.Windows.Forms.Button();
            this.lbl1vs1 = new System.Windows.Forms.Label();
            this.lblTournoi = new System.Windows.Forms.Label();
            this.rdo1vs1 = new System.Windows.Forms.RadioButton();
            this.rdoTournoi = new System.Windows.Forms.RadioButton();
            this.pnlTournoi = new System.Windows.Forms.Panel();
            this.pnl1vs1 = new System.Windows.Forms.Panel();
            this.lblDef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblTitre.Location = new System.Drawing.Point(242, 26);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(307, 51);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "PUISSANCE 4";
            // 
            // btnParametres
            // 
            this.btnParametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnParametres.Location = new System.Drawing.Point(296, 412);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(198, 51);
            this.btnParametres.TabIndex = 1;
            this.btnParametres.Text = "Paramètres";
            this.btnParametres.UseVisualStyleBackColor = true;
            this.btnParametres.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1vs1
            // 
            this.lbl1vs1.AutoSize = true;
            this.lbl1vs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl1vs1.Location = new System.Drawing.Point(144, 197);
            this.lbl1vs1.Name = "lbl1vs1";
            this.lbl1vs1.Size = new System.Drawing.Size(112, 74);
            this.lbl1vs1.TabIndex = 2;
            this.lbl1vs1.Text = "MODE\r\n1 vs 1\r\n";
            this.lbl1vs1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTournoi
            // 
            this.lblTournoi.AutoSize = true;
            this.lblTournoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTournoi.Location = new System.Drawing.Point(474, 197);
            this.lblTournoi.Name = "lblTournoi";
            this.lblTournoi.Size = new System.Drawing.Size(173, 74);
            this.lblTournoi.TabIndex = 3;
            this.lblTournoi.Text = "MODE\n TOURNOI";
            this.lblTournoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdo1vs1
            // 
            this.rdo1vs1.AutoSize = true;
            this.rdo1vs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rdo1vs1.Location = new System.Drawing.Point(193, 298);
            this.rdo1vs1.Name = "rdo1vs1";
            this.rdo1vs1.Size = new System.Drawing.Size(14, 13);
            this.rdo1vs1.TabIndex = 4;
            this.rdo1vs1.TabStop = true;
            this.rdo1vs1.UseVisualStyleBackColor = true;
            // 
            // rdoTournoi
            // 
            this.rdoTournoi.AutoSize = true;
            this.rdoTournoi.Location = new System.Drawing.Point(554, 298);
            this.rdoTournoi.Name = "rdoTournoi";
            this.rdoTournoi.Size = new System.Drawing.Size(14, 13);
            this.rdoTournoi.TabIndex = 5;
            this.rdoTournoi.TabStop = true;
            this.rdoTournoi.UseVisualStyleBackColor = true;
            // 
            // pnlTournoi
            // 
            this.pnlTournoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTournoi.Location = new System.Drawing.Point(450, 183);
            this.pnlTournoi.Name = "pnlTournoi";
            this.pnlTournoi.Size = new System.Drawing.Size(220, 143);
            this.pnlTournoi.TabIndex = 6;
            // 
            // pnl1vs1
            // 
            this.pnl1vs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1vs1.Location = new System.Drawing.Point(89, 183);
            this.pnl1vs1.Name = "pnl1vs1";
            this.pnl1vs1.Size = new System.Drawing.Size(220, 143);
            this.pnl1vs1.TabIndex = 7;
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblDef.Location = new System.Drawing.Point(232, 98);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(327, 37);
            this.lblDef.TabIndex = 8;
            this.lblDef.Text = "Choix du mode de jeu";
            // 
            // FormLancement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 497);
            this.Controls.Add(this.lblDef);
            this.Controls.Add(this.rdoTournoi);
            this.Controls.Add(this.rdo1vs1);
            this.Controls.Add(this.lblTournoi);
            this.Controls.Add(this.lbl1vs1);
            this.Controls.Add(this.btnParametres);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pnlTournoi);
            this.Controls.Add(this.pnl1vs1);
            this.Name = "FormLancement";
            this.Text = "Puissance 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lbl1vs1;
        private System.Windows.Forms.Label lblTournoi;
        private System.Windows.Forms.Label lblDef;

        private System.Windows.Forms.Button btnParametres;

        private System.Windows.Forms.RadioButton rdo1vs1;
        private System.Windows.Forms.RadioButton rdoTournoi;

        private System.Windows.Forms.Panel pnlTournoi;
        private System.Windows.Forms.Panel pnl1vs1;

    }
}

