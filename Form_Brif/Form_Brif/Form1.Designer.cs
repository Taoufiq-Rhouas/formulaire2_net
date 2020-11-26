
namespace Form_Brif
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_pays = new System.Windows.Forms.ComboBox();
            this.comboBox_ville = new System.Windows.Forms.ComboBox();
            this.comboBox_specialite = new System.Windows.Forms.ComboBox();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.label_err_name = new System.Windows.Forms.Label();
            this.label_err_prenom = new System.Windows.Forms.Label();
            this.label_err_tel = new System.Windows.Forms.Label();
            this.label_err_email = new System.Windows.Forms.Label();
            this.label_err_pays = new System.Windows.Forms.Label();
            this.label_err_ville = new System.Windows.Forms.Label();
            this.label_err_specialite = new System.Windows.Forms.Label();
            this.label_succes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_vider = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_err_adress = new System.Windows.Forms.Label();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.button_Modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(191, 78);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(200, 20);
            this.textBox_nom.TabIndex = 1;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(191, 127);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(200, 20);
            this.textBox_prenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date De Naissance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.Location = new System.Drawing.Point(191, 279);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(200, 20);
            this.textBox_telephone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numéro De Téléphone";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(191, 228);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(200, 20);
            this.textBox_email.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pays";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Villes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "choix des spécialités";
            // 
            // comboBox_pays
            // 
            this.comboBox_pays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pays.FormattingEnabled = true;
            this.comboBox_pays.Items.AddRange(new object[] {
            "Maroc",
            "France",
            "Allemand"});
            this.comboBox_pays.Location = new System.Drawing.Point(191, 393);
            this.comboBox_pays.Name = "comboBox_pays";
            this.comboBox_pays.Size = new System.Drawing.Size(200, 21);
            this.comboBox_pays.TabIndex = 13;
            this.comboBox_pays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_ville
            // 
            this.comboBox_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ville.FormattingEnabled = true;
            this.comboBox_ville.Location = new System.Drawing.Point(191, 443);
            this.comboBox_ville.Name = "comboBox_ville";
            this.comboBox_ville.Size = new System.Drawing.Size(200, 21);
            this.comboBox_ville.TabIndex = 14;
            // 
            // comboBox_specialite
            // 
            this.comboBox_specialite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_specialite.FormattingEnabled = true;
            this.comboBox_specialite.Items.AddRange(new object[] {
            "C#",
            "JEE",
            "Back-End & Front-End"});
            this.comboBox_specialite.Location = new System.Drawing.Point(191, 489);
            this.comboBox_specialite.Name = "comboBox_specialite";
            this.comboBox_specialite.Size = new System.Drawing.Size(200, 21);
            this.comboBox_specialite.TabIndex = 15;
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ajouter.Location = new System.Drawing.Point(409, 424);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(235, 40);
            this.button_Ajouter.TabIndex = 16;
            this.button_Ajouter.Text = "Ajouter";
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // label_err_name
            // 
            this.label_err_name.AutoSize = true;
            this.label_err_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_name.ForeColor = System.Drawing.Color.Red;
            this.label_err_name.Location = new System.Drawing.Point(188, 101);
            this.label_err_name.Name = "label_err_name";
            this.label_err_name.Size = new System.Drawing.Size(0, 16);
            this.label_err_name.TabIndex = 17;
            // 
            // label_err_prenom
            // 
            this.label_err_prenom.AutoSize = true;
            this.label_err_prenom.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_prenom.ForeColor = System.Drawing.Color.Red;
            this.label_err_prenom.Location = new System.Drawing.Point(188, 150);
            this.label_err_prenom.Name = "label_err_prenom";
            this.label_err_prenom.Size = new System.Drawing.Size(0, 16);
            this.label_err_prenom.TabIndex = 18;
            // 
            // label_err_tel
            // 
            this.label_err_tel.AutoSize = true;
            this.label_err_tel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_tel.ForeColor = System.Drawing.Color.Red;
            this.label_err_tel.Location = new System.Drawing.Point(188, 302);
            this.label_err_tel.Name = "label_err_tel";
            this.label_err_tel.Size = new System.Drawing.Size(0, 16);
            this.label_err_tel.TabIndex = 19;
            // 
            // label_err_email
            // 
            this.label_err_email.AutoSize = true;
            this.label_err_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_email.ForeColor = System.Drawing.Color.Red;
            this.label_err_email.Location = new System.Drawing.Point(188, 251);
            this.label_err_email.Name = "label_err_email";
            this.label_err_email.Size = new System.Drawing.Size(0, 16);
            this.label_err_email.TabIndex = 20;
            // 
            // label_err_pays
            // 
            this.label_err_pays.AutoSize = true;
            this.label_err_pays.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_pays.ForeColor = System.Drawing.Color.Red;
            this.label_err_pays.Location = new System.Drawing.Point(188, 417);
            this.label_err_pays.Name = "label_err_pays";
            this.label_err_pays.Size = new System.Drawing.Size(0, 16);
            this.label_err_pays.TabIndex = 21;
            // 
            // label_err_ville
            // 
            this.label_err_ville.AutoSize = true;
            this.label_err_ville.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_ville.ForeColor = System.Drawing.Color.Red;
            this.label_err_ville.Location = new System.Drawing.Point(188, 467);
            this.label_err_ville.Name = "label_err_ville";
            this.label_err_ville.Size = new System.Drawing.Size(0, 16);
            this.label_err_ville.TabIndex = 22;
            // 
            // label_err_specialite
            // 
            this.label_err_specialite.AutoSize = true;
            this.label_err_specialite.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_specialite.ForeColor = System.Drawing.Color.Red;
            this.label_err_specialite.Location = new System.Drawing.Point(188, 513);
            this.label_err_specialite.Name = "label_err_specialite";
            this.label_err_specialite.Size = new System.Drawing.Size(0, 16);
            this.label_err_specialite.TabIndex = 23;
            // 
            // label_succes
            // 
            this.label_succes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_succes.AutoSize = true;
            this.label_succes.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_succes.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label_succes.Location = new System.Drawing.Point(356, 547);
            this.label_succes.Name = "label_succes";
            this.label_succes.Size = new System.Drawing.Size(0, 36);
            this.label_succes.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(499, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Gestion Des Apprenants ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 326);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_vider
            // 
            this.button_vider.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vider.Location = new System.Drawing.Point(409, 477);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(235, 39);
            this.button_vider.TabIndex = 27;
            this.button_vider.Text = "vider";
            this.button_vider.UseVisualStyleBackColor = true;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(904, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 39);
            this.button3.TabIndex = 28;
            this.button3.Text = "fermer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_err_adress
            // 
            this.label_err_adress.AutoSize = true;
            this.label_err_adress.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_err_adress.ForeColor = System.Drawing.Color.Red;
            this.label_err_adress.Location = new System.Drawing.Point(188, 359);
            this.label_err_adress.Name = "label_err_adress";
            this.label_err_adress.Size = new System.Drawing.Size(0, 16);
            this.label_err_adress.TabIndex = 33;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(191, 336);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(200, 20);
            this.textBox_adress.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "Adresse";
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Supprimer.Location = new System.Drawing.Point(904, 423);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(235, 40);
            this.button_Supprimer.TabIndex = 35;
            this.button_Supprimer.Text = "Supprimer";
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // button_Modifier
            // 
            this.button_Modifier.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modifier.Location = new System.Drawing.Point(659, 424);
            this.button_Modifier.Name = "button_Modifier";
            this.button_Modifier.Size = new System.Drawing.Size(235, 40);
            this.button_Modifier.TabIndex = 36;
            this.button_Modifier.Text = "Modifier";
            this.button_Modifier.UseVisualStyleBackColor = true;
            this.button_Modifier.Click += new System.EventHandler(this.button_Modifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 599);
            this.Controls.Add(this.button_Modifier);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.label_err_adress);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_vider);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_succes);
            this.Controls.Add(this.label_err_specialite);
            this.Controls.Add(this.label_err_ville);
            this.Controls.Add(this.label_err_pays);
            this.Controls.Add(this.label_err_email);
            this.Controls.Add(this.label_err_tel);
            this.Controls.Add(this.label_err_prenom);
            this.Controls.Add(this.label_err_name);
            this.Controls.Add(this.button_Ajouter);
            this.Controls.Add(this.comboBox_specialite);
            this.Controls.Add(this.comboBox_ville);
            this.Controls.Add(this.comboBox_pays);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_telephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_pays;
        private System.Windows.Forms.ComboBox comboBox_ville;
        private System.Windows.Forms.ComboBox comboBox_specialite;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Label label_err_name;
        private System.Windows.Forms.Label label_err_prenom;
        private System.Windows.Forms.Label label_err_tel;
        private System.Windows.Forms.Label label_err_email;
        private System.Windows.Forms.Label label_err_pays;
        private System.Windows.Forms.Label label_err_ville;
        private System.Windows.Forms.Label label_err_specialite;
        private System.Windows.Forms.Label label_succes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_err_adress;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.Button button_Modifier;
    }
}

