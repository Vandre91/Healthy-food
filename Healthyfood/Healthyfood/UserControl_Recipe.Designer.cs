namespace Healthyfood
{
    partial class UserControl_Recipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Recipe));
            this.button_Back = new System.Windows.Forms.Button();
            this.button1_recipe_health = new System.Windows.Forms.Button();
            this.button2_yours_recipes = new System.Windows.Forms.Button();
            this.button3_world_recipes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(653, 471);
            this.button_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(100, 28);
            this.button_Back.TabIndex = 0;
            this.button_Back.Text = "Retour";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button1_recipe_health
            // 
            this.button1_recipe_health.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1_recipe_health.BackgroundImage")));
            this.button1_recipe_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_recipe_health.Location = new System.Drawing.Point(243, 86);
            this.button1_recipe_health.Name = "button1_recipe_health";
            this.button1_recipe_health.Size = new System.Drawing.Size(300, 92);
            this.button1_recipe_health.TabIndex = 1;
            this.button1_recipe_health.Text = "Recettes santé";
            this.button1_recipe_health.UseVisualStyleBackColor = true;
            this.button1_recipe_health.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_yours_recipes
            // 
            this.button2_yours_recipes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2_yours_recipes.BackgroundImage")));
            this.button2_yours_recipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_yours_recipes.Location = new System.Drawing.Point(243, 221);
            this.button2_yours_recipes.Name = "button2_yours_recipes";
            this.button2_yours_recipes.Size = new System.Drawing.Size(300, 92);
            this.button2_yours_recipes.TabIndex = 2;
            this.button2_yours_recipes.Text = "Vos recettes";
            this.button2_yours_recipes.UseVisualStyleBackColor = true;
            // 
            // button3_world_recipes
            // 
            this.button3_world_recipes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3_world_recipes.BackgroundImage")));
            this.button3_world_recipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_world_recipes.Location = new System.Drawing.Point(243, 368);
            this.button3_world_recipes.Name = "button3_world_recipes";
            this.button3_world_recipes.Size = new System.Drawing.Size(300, 92);
            this.button3_world_recipes.TabIndex = 3;
            this.button3_world_recipes.Text = "         Recettes du monde";
            this.button3_world_recipes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3_world_recipes.UseVisualStyleBackColor = true;
            // 
            // UserControl_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button3_world_recipes);
            this.Controls.Add(this.button2_yours_recipes);
            this.Controls.Add(this.button1_recipe_health);
            this.Controls.Add(this.button_Back);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_Recipe";
            this.Size = new System.Drawing.Size(831, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button1_recipe_health;
        private System.Windows.Forms.Button button2_yours_recipes;
        private System.Windows.Forms.Button button3_world_recipes;
    }
}
