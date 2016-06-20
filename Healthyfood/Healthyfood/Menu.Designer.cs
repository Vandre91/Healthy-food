﻿namespace Healthyfood
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
            this.userControl_Profil1 = new Healthyfood.UserControl_Profil();
            this.userControl_Reserve1 = new Healthyfood.UserControl_Reserve();
            this.userControl_Recipe1 = new Healthyfood.UserControl_Recipe();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saugarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Provisions
            // 
            this.button_Provisions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Provisions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Provisions.BackgroundImage")));
            this.button_Provisions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Provisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Provisions.Location = new System.Drawing.Point(295, 218);
            this.button_Provisions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Provisions.Name = "button_Provisions";
            this.button_Provisions.Size = new System.Drawing.Size(372, 102);
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
            this.button_Recette.Location = new System.Drawing.Point(295, 327);
            this.button_Recette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Recette.Name = "button_Recette";
            this.button_Recette.Size = new System.Drawing.Size(372, 102);
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
            this.button_Utilisateur.Location = new System.Drawing.Point(295, 108);
            this.button_Utilisateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Utilisateur.Name = "button_Utilisateur";
            this.button_Utilisateur.Size = new System.Drawing.Size(372, 102);
            this.button_Utilisateur.TabIndex = 0;
            this.button_Utilisateur.Text = "Profil Utilisateur";
            this.button_Utilisateur.UseVisualStyleBackColor = false;
            this.button_Utilisateur.Click += new System.EventHandler(this.button_Utilisateur_Click);
            // 
            // userControl_Profil1
            // 
            this.userControl_Profil1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_Profil1.BackgroundImage")));
            this.userControl_Profil1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl_Profil1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Profil1.Location = new System.Drawing.Point(0, 28);
            this.userControl_Profil1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl_Profil1.Name = "userControl_Profil1";
            this.userControl_Profil1.Size = new System.Drawing.Size(1015, 678);
            this.userControl_Profil1.TabIndex = 3;
            this.userControl_Profil1.Visible = false;
            // 
            // userControl_Reserve1
            // 
            this.userControl_Reserve1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_Reserve1.BackgroundImage")));
            this.userControl_Reserve1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl_Reserve1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Reserve1.Location = new System.Drawing.Point(0, 28);
            this.userControl_Reserve1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl_Reserve1.Name = "userControl_Reserve1";
            this.userControl_Reserve1.Size = new System.Drawing.Size(1015, 678);
            this.userControl_Reserve1.TabIndex = 4;
            this.userControl_Reserve1.Visible = false;
            // 
            // userControl_Recipe1
            // 
            this.userControl_Recipe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_Recipe1.BackgroundImage")));
            this.userControl_Recipe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl_Recipe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Recipe1.Location = new System.Drawing.Point(0, 28);
            this.userControl_Recipe1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userControl_Recipe1.Name = "userControl_Recipe1";
            this.userControl_Recipe1.Size = new System.Drawing.Size(1015, 678);
            this.userControl_Recipe1.TabIndex = 5;
            this.userControl_Recipe1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saugarderToolStripMenuItem,
            this.chargerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // saugarderToolStripMenuItem
            // 
            this.saugarderToolStripMenuItem.Name = "saugarderToolStripMenuItem";
            this.saugarderToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.saugarderToolStripMenuItem.Text = "Saugarder";
            this.saugarderToolStripMenuItem.Click += new System.EventHandler(this.saugarderToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 706);
            this.Controls.Add(this.userControl_Recipe1);
            this.Controls.Add(this.userControl_Reserve1);
            this.Controls.Add(this.userControl_Profil1);
            this.Controls.Add(this.button_Recette);
            this.Controls.Add(this.button_Provisions);
            this.Controls.Add(this.button_Utilisateur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Utilisateur;
        private System.Windows.Forms.Button button_Provisions;
        private System.Windows.Forms.Button button_Recette;
        private UserControl_Profil userControl_Profil1;
        private UserControl_Reserve userControl_Reserve1;
        private UserControl_Recipe userControl_Recipe1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saugarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
    }
}

