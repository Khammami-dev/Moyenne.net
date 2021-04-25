using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calculer_Click(object sender, EventArgs e)
        {
            //Double ds = (double.Parse(txt_NoteDS.Text))*0.2;
            //Double exam = (double.Parse(txt_NoteExamen.Text)) * 0.5;
            //Double np = (double.Parse(txt_NoteNP.Text)) * 0.2;
            // ListeDePersonnes l = new ListeDePersonnes();
            Etudiant etudiant = new Etudiant (txt_NomPrenom.Text, double.Parse(txt_NoteDS.Text),
                double.Parse(txt_NoteExamen.Text), double.Parse(txt_NoteNP.Text));

            txt_Moyenne.Text = etudiant.calculer(double.Parse(txt_NoteDS.Text), double.Parse(txt_NoteExamen.Text), double.Parse(txt_NoteNP.Text)).ToString();


        }

        private void txt_NomPrenom_TextChanged(object sender, EventArgs e)
        {
            if(txt_NomPrenom.Text != "" && txt_NoteDS.Text != "" && txt_NoteExamen.Text != "" && txt_NoteNP.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
        }

        private void txt_NomPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txt_NoteDS_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteDS.Text != "" && txt_NoteExamen.Text != "" && txt_NoteNP.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
        }

        private void txt_NoteDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txt_NoteExamen_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteDS.Text != "" && txt_NoteExamen.Text != "" && txt_NoteNP.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
        }

        private void txt_NoteNP_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteDS.Text != "" && txt_NoteExamen.Text != "" && txt_NoteNP.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
        }

        private void txt_NoteExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txt_NoteNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Add(txt_NomPrenom.Text + " " + txt_Moyenne.Text);
            txt_NomPrenom.Text = "";
            txt_NoteDS.Text = "";
            txt_NoteExamen.Text = "";
            txt_NoteNP.Text = "";
            txt_Moyenne.Text = "";
            btn_Calculer.Enabled = false;
            btn_Ajouter.Enabled = false;
        }

        private void txt_Moyenne_TextChanged(object sender, EventArgs e)
        {
            if(txt_Moyenne.Text != "")
            {
                btn_Ajouter.Enabled = true;
                
            }
        }

        private void lst_Moyenne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_Moyenne.Items.Count != 0)
            {
                btn_Supprimer.Enabled = true;
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Remove(lst_Moyenne.SelectedItem);
            btn_Supprimer.Enabled = false;
        }
    }
}
