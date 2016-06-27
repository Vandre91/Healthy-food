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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl_Recipe_Utilisateur1 = new Healthyfood.UserControl_Recipe_Utilisateur();
            this.userControl_World_Recipe1 = new Healthyfood.UserControl_World_Recipe();
            this.userControl_Your_Recipes1 = new Healthyfood.UserControl_Your_Recipes();
            this.userControl_Recipe_Healthy1 = new Healthyfood.UserControl_Recipe_Healthy();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(653, 471);
            this.button_Back.Margin = new System.Windows.Forms.Padding(4);
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
            this.button1_recipe_health.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1_recipe_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_recipe_health.Location = new System.Drawing.Point(243, 86);
            this.button1_recipe_health.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button2_yours_recipes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2_yours_recipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_yours_recipes.Location = new System.Drawing.Point(243, 222);
            this.button2_yours_recipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2_yours_recipes.Name = "button2_yours_recipes";
            this.button2_yours_recipes.Size = new System.Drawing.Size(300, 92);
            this.button2_yours_recipes.TabIndex = 2;
            this.button2_yours_recipes.Text = "Vos recettes";
            this.button2_yours_recipes.UseVisualStyleBackColor = true;
            this.button2_yours_recipes.Click += new System.EventHandler(this.button2_yours_recipes_Click);
            // 
            // button3_world_recipes
            // 
            this.button3_world_recipes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3_world_recipes.BackgroundImage")));
            this.button3_world_recipes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3_world_recipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_world_recipes.Location = new System.Drawing.Point(243, 368);
            this.button3_world_recipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3_world_recipes.Name = "button3_world_recipes";
            this.button3_world_recipes.Size = new System.Drawing.Size(300, 92);
            this.button3_world_recipes.TabIndex = 3;
            this.button3_world_recipes.Text = "         Recettes du monde";
            this.button3_world_recipes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3_world_recipes.UseVisualStyleBackColor = true;
            this.button3_world_recipes.Click += new System.EventHandler(this.button3_world_recipes_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Lastname});
            this.listView1.Location = new System.Drawing.Point(605, 86);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(183, 118);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Nom";
            // 
            // columnHeader_Lastname
            // 
            this.columnHeader_Lastname.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(615, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selection de l\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(615, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selectioner un  utilisateur";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Crée vos recettes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userControl_Recipe_Utilisateur1
            // 
            this.userControl_Recipe_Utilisateur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Recipe_Utilisateur1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Recipe_Utilisateur1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Recipe_Utilisateur1.Name = "userControl_Recipe_Utilisateur1";
            this.userControl_Recipe_Utilisateur1.Size = new System.Drawing.Size(831, 550);
            this.userControl_Recipe_Utilisateur1.TabIndex = 14;
            this.userControl_Recipe_Utilisateur1.Visible = false;
            // 
            // userControl_World_Recipe1
            // 
            this.userControl_World_Recipe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_World_Recipe1.Location = new System.Drawing.Point(0, 0);
            this.userControl_World_Recipe1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_World_Recipe1.Name = "userControl_World_Recipe1";
            this.userControl_World_Recipe1.Size = new System.Drawing.Size(831, 550);
            this.userControl_World_Recipe1.TabIndex = 13;
            this.userControl_World_Recipe1.Visible = false;
            // 
            // userControl_Your_Recipes1
            // 
            this.userControl_Your_Recipes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Your_Recipes1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Your_Recipes1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Your_Recipes1.Name = "userControl_Your_Recipes1";
            this.userControl_Your_Recipes1.Size = new System.Drawing.Size(831, 550);
            this.userControl_Your_Recipes1.TabIndex = 12;
            this.userControl_Your_Recipes1.Visible = false;
            // 
            // userControl_Recipe_Healthy1
            // 
            this.userControl_Recipe_Healthy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Recipe_Healthy1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Recipe_Healthy1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Recipe_Healthy1.Name = "userControl_Recipe_Healthy1";
            this.userControl_Recipe_Healthy1.Size = new System.Drawing.Size(831, 550);
            this.userControl_Recipe_Healthy1.TabIndex = 11;
            this.userControl_Recipe_Healthy1.Visible = false;
            // 
            // UserControl_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.userControl_Recipe_Utilisateur1);
            this.Controls.Add(this.userControl_World_Recipe1);
            this.Controls.Add(this.userControl_Your_Recipes1);
            this.Controls.Add(this.userControl_Recipe_Healthy1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3_world_recipes);
            this.Controls.Add(this.button2_yours_recipes);
            this.Controls.Add(this.button1_recipe_health);
            this.Controls.Add(this.button_Back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Recipe";
            this.Size = new System.Drawing.Size(831, 550);
            this.Enter += new System.EventHandler(this.UserControl_Recipe_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button1_recipe_health;
        private System.Windows.Forms.Button button2_yours_recipes;
        private System.Windows.Forms.Button button3_world_recipes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private UserControl_Recipe_Healthy userControl_Recipe_Healthy1;
        private UserControl_Your_Recipes userControl_Your_Recipes1;
        private UserControl_World_Recipe userControl_World_Recipe1;
        private UserControl_Recipe_Utilisateur userControl_Recipe_Utilisateur1;
    }
}
