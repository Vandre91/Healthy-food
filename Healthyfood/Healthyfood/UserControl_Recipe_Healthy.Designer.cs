namespace Healthyfood
{
    partial class UserControl_Recipe_Healthy
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Le abdul",
            "belle et bien présenter"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Back = new System.Windows.Forms.Button();
            this.panel_Show_Recipes = new System.Windows.Forms.Panel();
            this.label_Describes = new System.Windows.Forms.Label();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Heat = new System.Windows.Forms.Button();
            this.button_Back_Panel = new System.Windows.Forms.Button();
            this.panel_Show_Recipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Description,
            this.columnHeader_Note});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 303);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 107;
            // 
            // columnHeader_Description
            // 
            this.columnHeader_Description.Text = "Déscription";
            this.columnHeader_Description.Width = 458;
            // 
            // columnHeader_Note
            // 
            this.columnHeader_Note.Text = "Note";
            this.columnHeader_Note.Width = 43;
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.Location = new System.Drawing.Point(479, 309);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(92, 23);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "Retour";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // panel_Show_Recipes
            // 
            this.panel_Show_Recipes.Controls.Add(this.label_Describes);
            this.panel_Show_Recipes.Controls.Add(this.button_Read);
            this.panel_Show_Recipes.Controls.Add(this.button_Heat);
            this.panel_Show_Recipes.Controls.Add(this.button_Back_Panel);
            this.panel_Show_Recipes.Location = new System.Drawing.Point(95, 41);
            this.panel_Show_Recipes.Name = "panel_Show_Recipes";
            this.panel_Show_Recipes.Size = new System.Drawing.Size(366, 227);
            this.panel_Show_Recipes.TabIndex = 2;
            this.panel_Show_Recipes.Visible = false;
            // 
            // label_Describes
            // 
            this.label_Describes.AutoSize = true;
            this.label_Describes.Location = new System.Drawing.Point(30, 25);
            this.label_Describes.Name = "label_Describes";
            this.label_Describes.Size = new System.Drawing.Size(60, 13);
            this.label_Describes.TabIndex = 3;
            this.label_Describes.Text = "Déscription";
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(147, 188);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(75, 23);
            this.button_Read.TabIndex = 2;
            this.button_Read.Text = "Lire";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Heat
            // 
            this.button_Heat.Location = new System.Drawing.Point(30, 188);
            this.button_Heat.Name = "button_Heat";
            this.button_Heat.Size = new System.Drawing.Size(75, 23);
            this.button_Heat.TabIndex = 1;
            this.button_Heat.Text = "Manger";
            this.button_Heat.UseVisualStyleBackColor = true;
            this.button_Heat.Click += new System.EventHandler(this.button_Heat_Click);
            // 
            // button_Back_Panel
            // 
            this.button_Back_Panel.Location = new System.Drawing.Point(276, 188);
            this.button_Back_Panel.Name = "button_Back_Panel";
            this.button_Back_Panel.Size = new System.Drawing.Size(75, 23);
            this.button_Back_Panel.TabIndex = 0;
            this.button_Back_Panel.Text = "Retour";
            this.button_Back_Panel.UseVisualStyleBackColor = true;
            this.button_Back_Panel.Click += new System.EventHandler(this.button_Back_Panel_Click);
            // 
            // UserControl_Recipe_Healthy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Show_Recipes);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.listView1);
            this.Name = "UserControl_Recipe_Healthy";
            this.Size = new System.Drawing.Size(574, 342);
            this.Enter += new System.EventHandler(this.UserControl_Recipe_Healthy_Enter);
            this.panel_Show_Recipes.ResumeLayout(false);
            this.panel_Show_Recipes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Description;
        private System.Windows.Forms.ColumnHeader columnHeader_Note;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Panel panel_Show_Recipes;
        private System.Windows.Forms.Label label_Describes;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Heat;
        private System.Windows.Forms.Button button_Back_Panel;
    }
}
