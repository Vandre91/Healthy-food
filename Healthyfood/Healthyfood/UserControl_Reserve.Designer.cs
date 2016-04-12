namespace Healthyfood
{
    partial class UserControl_Reserve
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Reserve));
            this.button_Add_Remove = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Add_Remove
            // 
            this.button_Add_Remove.Location = new System.Drawing.Point(288, 139);
            this.button_Add_Remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Add_Remove.Name = "button_Add_Remove";
            this.button_Add_Remove.Size = new System.Drawing.Size(296, 71);
            this.button_Add_Remove.TabIndex = 0;
            this.button_Add_Remove.Text = "Ajouter/Retirer";
            this.button_Add_Remove.UseVisualStyleBackColor = true;
            this.button_Add_Remove.Click += new System.EventHandler(this.button_Add_Remove_Click);
            // 
            // button_Show
            // 
            this.button_Show.Location = new System.Drawing.Point(288, 250);
            this.button_Show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(296, 71);
            this.button_Show.TabIndex = 1;
            this.button_Show.Text = "Visualiser";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(704, 446);
            this.button_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(100, 28);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "Retour";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // UserControl_Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_Add_Remove);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_Reserve";
            this.Size = new System.Drawing.Size(872, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add_Remove;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Back;
    }
}
