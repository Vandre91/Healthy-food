namespace Healthyfood
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_Provisions = new System.Windows.Forms.Button();
            this.button_Recette = new System.Windows.Forms.Button();
            this.button_Utilisateur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Provisions
            // 
            this.button_Provisions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Provisions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Provisions.BackgroundImage")));
            this.button_Provisions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Provisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Provisions.Location = new System.Drawing.Point(169, 177);
            this.button_Provisions.Name = "button_Provisions";
            this.button_Provisions.Size = new System.Drawing.Size(279, 83);
            this.button_Provisions.TabIndex = 1;
            this.button_Provisions.Text = "Provisions";
            this.button_Provisions.UseVisualStyleBackColor = true;
            this.button_Provisions.Click += new System.EventHandler(this.button_Provisions_Click);
            // 
            // button_Recette
            // 
            this.button_Recette.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Recette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Recette.BackgroundImage")));
            this.button_Recette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Recette.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Recette.Location = new System.Drawing.Point(169, 266);
            this.button_Recette.Name = "button_Recette";
            this.button_Recette.Size = new System.Drawing.Size(279, 83);
            this.button_Recette.TabIndex = 2;
            this.button_Recette.Text = "Recettes";
            this.button_Recette.UseVisualStyleBackColor = true;
            this.button_Recette.Click += new System.EventHandler(this.button_Recette_Click);
            // 
            // button_Utilisateur
            // 
            this.button_Utilisateur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Utilisateur.BackColor = System.Drawing.Color.Transparent;
            this.button_Utilisateur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Utilisateur.BackgroundImage")));
            this.button_Utilisateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Utilisateur.Location = new System.Drawing.Point(169, 88);
            this.button_Utilisateur.Name = "button_Utilisateur";
            this.button_Utilisateur.Size = new System.Drawing.Size(279, 83);
            this.button_Utilisateur.TabIndex = 0;
            this.button_Utilisateur.Text = "Profil Utilisateur";
            this.button_Utilisateur.UseVisualStyleBackColor = false;
            this.button_Utilisateur.Click += new System.EventHandler(this.button_Utilisateur_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 433);
            this.Controls.Add(this.button_Recette);
            this.Controls.Add(this.button_Provisions);
            this.Controls.Add(this.button_Utilisateur);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Utilisateur;
        private System.Windows.Forms.Button button_Provisions;
        private System.Windows.Forms.Button button_Recette;
    }
}

