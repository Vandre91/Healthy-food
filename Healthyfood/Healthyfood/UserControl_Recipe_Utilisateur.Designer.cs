namespace Healthyfood
{
    partial class UserControl_Recipe_Utilisateur
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_fish = new System.Windows.Forms.Label();
            this.label_Drink = new System.Windows.Forms.Label();
            this.label_crustace = new System.Windows.Forms.Label();
            this.label_Milk = new System.Windows.Forms.Label();
            this.label_dessert = new System.Windows.Forms.Label();
            this.label_feculent = new System.Windows.Forms.Label();
            this.label_plante = new System.Windows.Forms.Label();
            this.label_fruit = new System.Windows.Forms.Label();
            this.label_poultry = new System.Windows.Forms.Label();
            this.label_backerie = new System.Windows.Forms.Label();
            this.label_vegetable = new System.Windows.Forms.Label();
            this.label_grasse = new System.Windows.Forms.Label();
            this.label_Beef = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader_Name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_back1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la recette";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste des ingrédients";
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_quantity});
            this.listView1.Location = new System.Drawing.Point(44, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 118);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Nom";
            this.columnHeader_Name.Width = 165;
            // 
            // columnHeader_quantity
            // 
            this.columnHeader_quantity.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Préparation";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(44, 332);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 102);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(437, 374);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 59);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Enrgistrer";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.Location = new System.Drawing.Point(518, 374);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 59);
            this.button_Back.TabIndex = 7;
            this.button_Back.Text = "Retour";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(286, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.label_fish);
            this.panel1.Controls.Add(this.label_Drink);
            this.panel1.Controls.Add(this.label_crustace);
            this.panel1.Controls.Add(this.label_Milk);
            this.panel1.Controls.Add(this.label_dessert);
            this.panel1.Controls.Add(this.label_feculent);
            this.panel1.Controls.Add(this.label_plante);
            this.panel1.Controls.Add(this.label_fruit);
            this.panel1.Controls.Add(this.label_poultry);
            this.panel1.Controls.Add(this.label_backerie);
            this.panel1.Controls.Add(this.label_vegetable);
            this.panel1.Controls.Add(this.label_grasse);
            this.panel1.Controls.Add(this.label_Beef);
            this.panel1.Location = new System.Drawing.Point(379, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 251);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // label_fish
            // 
            this.label_fish.AutoSize = true;
            this.label_fish.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fish.Location = new System.Drawing.Point(15, 44);
            this.label_fish.Name = "label_fish";
            this.label_fish.Size = new System.Drawing.Size(69, 18);
            this.label_fish.TabIndex = 12;
            this.label_fish.Text = "Poisson";
            this.label_fish.Click += new System.EventHandler(this.label_fish_Click);
            // 
            // label_Drink
            // 
            this.label_Drink.AutoSize = true;
            this.label_Drink.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Drink.Location = new System.Drawing.Point(15, 26);
            this.label_Drink.Name = "label_Drink";
            this.label_Drink.Size = new System.Drawing.Size(70, 18);
            this.label_Drink.TabIndex = 11;
            this.label_Drink.Text = "Boisson";
            this.label_Drink.Click += new System.EventHandler(this.label_Drink_Click);
            // 
            // label_crustace
            // 
            this.label_crustace.AutoSize = true;
            this.label_crustace.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_crustace.Location = new System.Drawing.Point(15, 187);
            this.label_crustace.Name = "label_crustace";
            this.label_crustace.Size = new System.Drawing.Size(79, 18);
            this.label_crustace.TabIndex = 10;
            this.label_crustace.Text = "Crustacé";
            this.label_crustace.Click += new System.EventHandler(this.label_crustace_Click);
            // 
            // label_Milk
            // 
            this.label_Milk.AutoSize = true;
            this.label_Milk.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Milk.Location = new System.Drawing.Point(15, 115);
            this.label_Milk.Name = "label_Milk";
            this.label_Milk.Size = new System.Drawing.Size(125, 18);
            this.label_Milk.TabIndex = 9;
            this.label_Milk.Text = "Produit laitier";
            this.label_Milk.Click += new System.EventHandler(this.label_Milk_Click);
            // 
            // label_dessert
            // 
            this.label_dessert.AutoSize = true;
            this.label_dessert.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dessert.Location = new System.Drawing.Point(15, 169);
            this.label_dessert.Name = "label_dessert";
            this.label_dessert.Size = new System.Drawing.Size(70, 18);
            this.label_dessert.TabIndex = 8;
            this.label_dessert.Text = "Dessert";
            this.label_dessert.Click += new System.EventHandler(this.label_dessert_Click);
            // 
            // label_feculent
            // 
            this.label_feculent.AutoSize = true;
            this.label_feculent.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_feculent.Location = new System.Drawing.Point(15, 151);
            this.label_feculent.Name = "label_feculent";
            this.label_feculent.Size = new System.Drawing.Size(78, 18);
            this.label_feculent.TabIndex = 7;
            this.label_feculent.Text = "Feculent";
            this.label_feculent.Click += new System.EventHandler(this.label_feculent_Click);
            // 
            // label_plante
            // 
            this.label_plante.AutoSize = true;
            this.label_plante.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plante.Location = new System.Drawing.Point(15, 205);
            this.label_plante.Name = "label_plante";
            this.label_plante.Size = new System.Drawing.Size(134, 18);
            this.label_plante.TabIndex = 6;
            this.label_plante.Text = "Herbe et plante";
            this.label_plante.Click += new System.EventHandler(this.label_plante_Click);
            // 
            // label_fruit
            // 
            this.label_fruit.AutoSize = true;
            this.label_fruit.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fruit.Location = new System.Drawing.Point(15, 97);
            this.label_fruit.Name = "label_fruit";
            this.label_fruit.Size = new System.Drawing.Size(50, 18);
            this.label_fruit.TabIndex = 5;
            this.label_fruit.Text = "Fruit";
            this.label_fruit.Click += new System.EventHandler(this.label_fruit_Click);
            // 
            // label_poultry
            // 
            this.label_poultry.AutoSize = true;
            this.label_poultry.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poultry.Location = new System.Drawing.Point(15, 62);
            this.label_poultry.Name = "label_poultry";
            this.label_poultry.Size = new System.Drawing.Size(71, 18);
            this.label_poultry.TabIndex = 4;
            this.label_poultry.Text = "Volaille";
            this.label_poultry.Click += new System.EventHandler(this.label_poultry_Click);
            // 
            // label_backerie
            // 
            this.label_backerie.AutoSize = true;
            this.label_backerie.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backerie.Location = new System.Drawing.Point(15, 223);
            this.label_backerie.Name = "label_backerie";
            this.label_backerie.Size = new System.Drawing.Size(105, 18);
            this.label_backerie.TabIndex = 3;
            this.label_backerie.Text = "Boulangerie";
            this.label_backerie.Click += new System.EventHandler(this.label_backerie_Click);
            // 
            // label_vegetable
            // 
            this.label_vegetable.AutoSize = true;
            this.label_vegetable.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vegetable.Location = new System.Drawing.Point(15, 80);
            this.label_vegetable.Name = "label_vegetable";
            this.label_vegetable.Size = new System.Drawing.Size(70, 18);
            this.label_vegetable.TabIndex = 2;
            this.label_vegetable.Text = "Legume";
            this.label_vegetable.Click += new System.EventHandler(this.label_vegetable_Click);
            // 
            // label_grasse
            // 
            this.label_grasse.AutoSize = true;
            this.label_grasse.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grasse.Location = new System.Drawing.Point(15, 133);
            this.label_grasse.Name = "label_grasse";
            this.label_grasse.Size = new System.Drawing.Size(127, 18);
            this.label_grasse.TabIndex = 1;
            this.label_grasse.Text = "Matiere grasse";
            this.label_grasse.Click += new System.EventHandler(this.label_grasse_Click);
            // 
            // label_Beef
            // 
            this.label_Beef.AutoSize = true;
            this.label_Beef.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Beef.Location = new System.Drawing.Point(15, 8);
            this.label_Beef.Name = "label_Beef";
            this.label_Beef.Size = new System.Drawing.Size(64, 18);
            this.label_Beef.TabIndex = 0;
            this.label_Beef.Text = "Viande";
            this.label_Beef.Click += new System.EventHandler(this.label_Beef_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name1});
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(208, 245);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // columnHeader_Name1
            // 
            this.columnHeader_Name1.Text = "Nom";
            this.columnHeader_Name1.Width = 199;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(492, 284);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(45, 23);
            this.button_Ok.TabIndex = 10;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Visible = false;
            this.button_Ok.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_back1
            // 
            this.button_back1.Location = new System.Drawing.Point(543, 284);
            this.button_back1.Name = "button_back1";
            this.button_back1.Size = new System.Drawing.Size(47, 23);
            this.button_back1.TabIndex = 11;
            this.button_back1.Text = "Retour";
            this.button_back1.UseVisualStyleBackColor = true;
            this.button_back1.Visible = false;
            this.button_back1.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserControl_Recipe_Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_back1);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Recipe_Utilisateur";
            this.Size = new System.Drawing.Size(613, 459);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_fish;
        private System.Windows.Forms.Label label_Drink;
        private System.Windows.Forms.Label label_crustace;
        private System.Windows.Forms.Label label_Milk;
        private System.Windows.Forms.Label label_dessert;
        private System.Windows.Forms.Label label_feculent;
        private System.Windows.Forms.Label label_plante;
        private System.Windows.Forms.Label label_fruit;
        private System.Windows.Forms.Label label_poultry;
        private System.Windows.Forms.Label label_backerie;
        private System.Windows.Forms.Label label_vegetable;
        private System.Windows.Forms.Label label_grasse;
        private System.Windows.Forms.Label label_Beef;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader_Name1;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_back1;
    }
}
