namespace Healthyfood
{
    partial class UserControl_Menu
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
            this.button_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Datef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Datel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Add = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl_Modify_Menu1 = new Healthyfood.UserControl_Modify_Menu();
            this.userControl_Add_Menu1 = new Healthyfood.UserControl_Add_Menu();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_back.Location = new System.Drawing.Point(350, 328);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 59);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionner votre menu de la semaine ";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Datef,
            this.columnHeader_Datel});
            this.listView1.Location = new System.Drawing.Point(34, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(292, 327);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Nom";
            this.columnHeader_Name.Width = 106;
            // 
            // columnHeader_Datef
            // 
            this.columnHeader_Datef.Text = "Date de débu";
            this.columnHeader_Datef.Width = 96;
            // 
            // columnHeader_Datel
            // 
            this.columnHeader_Datel.Text = "Date de fin";
            this.columnHeader_Datel.Width = 95;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(364, 71);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Ajouter";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_modify
            // 
            this.button_modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modify.Location = new System.Drawing.Point(364, 114);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(75, 23);
            this.button_modify.TabIndex = 4;
            this.button_modify.Text = "Modifier";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(364, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Suprimmer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl_Modify_Menu1
            // 
            this.userControl_Modify_Menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Modify_Menu1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Modify_Menu1.Name = "userControl_Modify_Menu1";
            this.userControl_Modify_Menu1.Size = new System.Drawing.Size(460, 406);
            this.userControl_Modify_Menu1.TabIndex = 7;
            this.userControl_Modify_Menu1.Visible = false;
            // 
            // userControl_Add_Menu1
            // 
            this.userControl_Add_Menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Add_Menu1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Add_Menu1.Name = "userControl_Add_Menu1";
            this.userControl_Add_Menu1.Size = new System.Drawing.Size(460, 406);
            this.userControl_Add_Menu1.TabIndex = 6;
            this.userControl_Add_Menu1.Visible = false;
            // 
            // UserControl_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl_Modify_Menu1);
            this.Controls.Add(this.userControl_Add_Menu1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_back);
            this.Name = "UserControl_Menu";
            this.Size = new System.Drawing.Size(460, 406);
            this.Enter += new System.EventHandler(this.UserControl_Menu_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Datef;
        private System.Windows.Forms.ColumnHeader columnHeader_Datel;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button1;
        private UserControl_Add_Menu userControl_Add_Menu1;
        private UserControl_Modify_Menu userControl_Modify_Menu1;
    }
}
