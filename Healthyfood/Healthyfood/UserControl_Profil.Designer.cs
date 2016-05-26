namespace Healthyfood
{
    partial class UserControl_Profil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Profil));
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_back = new System.Windows.Forms.Button();
            this.userControl_Modify_Profil1 = new Healthyfood.UserControl_Modify_Profil();
            this.userControl_Show_Profil1 = new Healthyfood.UserControl_Show_Profil();
            this.timer_refesh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(85, 349);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Ajouter";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(206, 349);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(75, 23);
            this.button_Modify.TabIndex = 1;
            this.button_Modify.Text = "Modifier";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(320, 349);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Suprimer";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_LastName,
            this.columnHeader_Firstname,
            this.columnHeader_Age});
            this.listView1.Location = new System.Drawing.Point(59, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 238);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_LastName
            // 
            this.columnHeader_LastName.Text = "Nom";
            this.columnHeader_LastName.Width = 203;
            // 
            // columnHeader_Firstname
            // 
            this.columnHeader_Firstname.Text = "Prenom";
            this.columnHeader_Firstname.Width = 210;
            // 
            // columnHeader_Age
            // 
            this.columnHeader_Age.Text = "Age";
            this.columnHeader_Age.Width = 48;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(430, 349);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click_1);
            // 
            // userControl_Modify_Profil1
            // 
            this.userControl_Modify_Profil1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Modify_Profil1.Name = "userControl_Modify_Profil1";
            this.userControl_Modify_Profil1.Size = new System.Drawing.Size(576, 423);
            this.userControl_Modify_Profil1.TabIndex = 7;
            this.userControl_Modify_Profil1.Visible = false;
            // 
            // userControl_Show_Profil1
            // 
            this.userControl_Show_Profil1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Show_Profil1.Name = "userControl_Show_Profil1";
            this.userControl_Show_Profil1.Size = new System.Drawing.Size(587, 423);
            this.userControl_Show_Profil1.TabIndex = 6;
            this.userControl_Show_Profil1.Visible = false;
            // 
            // timer_refesh
            // 
            this.timer_refesh.Interval = 10000;
            this.timer_refesh.Tick += new System.EventHandler(this.timer_refesh_Tick);
            // 
            // UserControl_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.userControl_Modify_Profil1);
            this.Controls.Add(this.userControl_Show_Profil1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_Add);
            this.Name = "UserControl_Profil";
            this.Size = new System.Drawing.Size(603, 426);
            this.Enter += new System.EventHandler(this.UserControl_Profil_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_LastName;
        private System.Windows.Forms.ColumnHeader columnHeader_Firstname;
        private System.Windows.Forms.ColumnHeader columnHeader_Age;
        private System.Windows.Forms.Button button_back;
        private UserControl_Show_Profil userControl_Show_Profil1;
        private UserControl_Modify_Profil userControl_Modify_Profil1;
        private System.Windows.Forms.Timer timer_refesh;
    }
}
