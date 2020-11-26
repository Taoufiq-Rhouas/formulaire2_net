using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Form_Brif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        TOOLS d = new TOOLS();

        //les variables pour les validation des champs
        int validname = 0;
        int validprenom = 0;
        int validtele = 0;
        int validemail = 0;
        int validadress = 0;
        int validpays = 0;
        int validville = 0;
        int specialite = 0;
        int pos = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            ROMPLIRGRIDE();

        }

        //pour romplisage gridview
        public void ROMPLIRGRIDE()
        {
            if(d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = "select * from apprenant";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
        }
















        public bool valid_name(string nom)
        {
            Regex check = new Regex(@"^([a-z-A-Z]+)$");
            bool valid = false;
            valid = check.IsMatch(nom);
            if (valid == true)
            {
                validname = 0;
                label_err_name.Text ="";
                return valid;
            }
            else
            {
                validname++;
                label_err_name.Text = "nom est incorrect";
                return valid;

            }
        }
        public bool valid_prenom(string prenom)
        {
            Regex check = new Regex(@"^([a-z-A-Z]+)$");
            bool valid = false;
            valid = check.IsMatch(prenom);
            if (valid == true)
            {
                validprenom = 0;
                label_err_prenom.Text = "";
                return valid;
            }
            else
            {
                validprenom++;
                label_err_prenom.Text = "prenom est incorrect";
                return valid;

            }
        }

        public bool isvalid_telephone(string n)
        {
            Regex check = new Regex(@"^([0-9]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                validtele = 0;
                label_err_tel.Text = "";
                return valid;
            }
            else
            {
                validtele++;
                label_err_tel.Text = "telephone est incorrect";
                return valid;
            }
        }

        public bool isvalid_email(string email)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valide = false;
            valide = check.IsMatch(email);
            if (valide == true)
            {
                validemail = 0;
                label_err_email.Text = "";
                return valide;
            }
            else
            {
                validemail++;
                label_err_email.Text = "email est incorrect";
                return false;
            }
        }

        
        public bool valid_adresse(string adress)
        {
            if (adress == "")
            {
                validadress++;
                label_err_adress.Text = "adress est incorrect";
                return true;
            }
            else
            {
                validadress = 0;
                label_err_adress.Text = "";
                return false;

            }
        }

        public bool valid_payes(string payes)
        {
            //valitation de champs pays
            if (payes == "")
            {
                validpays++;
                label_err_pays.Text = "merci de sélectionner un pays";
                return false;
            }
            else
            {
                label_err_pays.Text = "";
                validpays = 0;
                return true;
            }
        }

        public bool valid_ville(string ville)
        {
            //valitation de champs ville

            if (ville == "")
            {
                label_err_ville.Text = "merci de sélectionner une ville";
                validville++;
                return false;

            }
            else
            {
                label_err_ville.Text = "";
                validville = 0;
                return true;
            }
        }

        public bool valid_specialete(string specielite)
        {
            //valitation de champs spécialite
            if (specielite == "")
            {
                label_err_specialite.Text = "merci de sélectionner une spécialité";
                specialite++;
                return false;
            }
            else
            {
                label_err_specialite.Text = "";
                specialite = 0;
                return true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_pays.Text == "Maroc")
            {
                comboBox_ville.Items.Clear();
                comboBox_ville.Items.Add("Safi");
                comboBox_ville.Items.Add("Agadir");
                comboBox_ville.Items.Add("Esaouira");
                comboBox_ville.Items.Add("Titouan");
            }
            else if (comboBox_pays.Text == "France")
            {
                comboBox_ville.Items.Clear();
                comboBox_ville.Items.Add("Paris");
                comboBox_ville.Items.Add("Lyon");
                comboBox_ville.Items.Add("Toulouse");
                comboBox_ville.Items.Add("Tours");
            }
            else if (comboBox_pays.Text == "Allemand")
            {
                comboBox_ville.Items.Clear();
                comboBox_ville.Items.Add("Bonn");
                comboBox_ville.Items.Add("Berlin");
            }
        }



        //declaration de la methode nombre
        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = "select count(id) from apprenant where email ='" + textBox_email.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        //declaration de la methode ajouter
        public bool AJOUTER()
        {
            if (nombre() == 0)
            {
                d.cmd.CommandText = "insert into apprenant values ('" + textBox_nom.Text + "','" + textBox_prenom.Text + "','" + textBox_email.Text + "'," + textBox_telephone.Text + ",'" + textBox_adress.Text + "','" + comboBox_pays.Text + "','" + comboBox_ville.Text + "','" + comboBox_specialite.Text + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        //declaration de la methode modifier
        public bool MODIFIER()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = "update apprenant set nom = '" + textBox_nom.Text + "',prenom ='" + textBox_prenom.Text + "', telephone = " + textBox_telephone.Text + ", adrese = '" + textBox_adress.Text + "',pays='" + comboBox_pays.Text + "', ville ='" + comboBox_ville.Text + "' ,choixSpecialite = '" + comboBox_specialite.Text + "' where email = '" + textBox_email.Text + "' ";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        //declaration de la methode supprimer
        public bool SUPPRIMER()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = "delete from apprenant where email = '" + textBox_email.Text + "'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }





        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            valid_name(textBox_nom.Text);
            valid_prenom(textBox_prenom.Text);
            isvalid_email(textBox_email.Text);
            isvalid_telephone(textBox_telephone.Text);
            valid_adresse(textBox_adress.Text);
            valid_payes(comboBox_pays.Text);
            valid_ville(comboBox_ville.Text);
            valid_specialete(comboBox_specialite.Text);

            //message de validation
            if (validname == 0 && validprenom == 0 && validtele == 0 && validemail == 0 && validpays == 0 && validville == 0 && specialite == 0 && validadress == 0)
            {
                if (AJOUTER() == true)
                {
                    MessageBox.Show("ajouter avec sucees");
                    label_succes.Text = "ajouter avec sucees";
                    ROMPLIRGRIDE();
                }
                else
                {
                    MessageBox.Show("ce stagaire deja existe");
                }
            }
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            valid_name(textBox_nom.Text);
            valid_prenom(textBox_prenom.Text);
            isvalid_email(textBox_email.Text);
            isvalid_telephone(textBox_telephone.Text);
            valid_adresse(textBox_adress.Text);
            valid_payes(comboBox_pays.Text);
            valid_ville(comboBox_ville.Text);
            valid_specialete(comboBox_specialite.Text);

            //message de validation
            if (validname == 0 && validprenom == 0 && validtele == 0 && validemail == 0 && validpays == 0 && validville == 0 && specialite == 0 && validadress == 0)
            {
                if (MODIFIER() == true)
                {
                    MessageBox.Show("modifier avec sucees");
                    label_succes.Text = "modifier avec sucees";
                    ROMPLIRGRIDE();
                }
                else
                {
                    MessageBox.Show("cr stagaire n'existe pas");
                }
            }
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            isvalid_email(textBox_email.Text);
            if (validemail != 0)
            {
                MessageBox.Show("err romplir email");
                return;
            }
            if (SUPPRIMER() == true)
            {
                MessageBox.Show("supprimer avec sucees");
                label_succes.Text = "supprimer avec sucees";
                ROMPLIRGRIDE();
            }
            else
            {
                MessageBox.Show("cr stagaire n'existev pas");
            }
        }

        public void VIDER(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.GetType() == typeof(ComboBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                {
                    VIDER(ct);
                }
            }
        }

        //button vider
        private void button_vider_Click(object sender, EventArgs e)
        {
            VIDER(this);
        }

        //button fermer
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vouez vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                d.DECONNECTER();
                this.Close();

            }
        }

        private void Afficher(int row)
        {
            this.textBox_nom.Text = d.dt.Rows[row][1].ToString();
            this.textBox_prenom.Text = d.dt.Rows[row][2].ToString();
            this.textBox_email.Text = d.dt.Rows[row][3].ToString();
            this.textBox_telephone.Text = d.dt.Rows[row][4].ToString();
            this.textBox_adress.Text = d.dt.Rows[row][5].ToString();
            this.comboBox_pays.Text = d.dt.Rows[row][6].ToString();
            this.comboBox_ville.Text = d.dt.Rows[row][7].ToString();
            this.comboBox_specialite.Text = d.dt.Rows[row][8].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = this.dataGridView1.CurrentCell.RowIndex;
            Afficher(pos);
        }
    }
}
