
namespace tp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Calculer = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.txt_NomPrenom = new System.Windows.Forms.TextBox();
            this.txt_NoteDS = new System.Windows.Forms.TextBox();
            this.txt_NoteExamen = new System.Windows.Forms.TextBox();
            this.txt_NoteNP = new System.Windows.Forms.TextBox();
            this.txt_Moyenne = new System.Windows.Forms.TextBox();
            this.lst_Moyenne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom et Prenom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note DS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note examen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note Tp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Moyenne";
            // 
            // btn_Calculer
            // 
            this.btn_Calculer.Enabled = false;
            this.btn_Calculer.Location = new System.Drawing.Point(57, 312);
            this.btn_Calculer.Name = "btn_Calculer";
            this.btn_Calculer.Size = new System.Drawing.Size(122, 30);
            this.btn_Calculer.TabIndex = 5;
            this.btn_Calculer.Text = "Calculer";
            this.btn_Calculer.UseVisualStyleBackColor = true;
            this.btn_Calculer.Click += new System.EventHandler(this.btn_Calculer_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Enabled = false;
            this.btn_Ajouter.Location = new System.Drawing.Point(185, 312);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(120, 30);
            this.btn_Ajouter.TabIndex = 6;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Enabled = false;
            this.btn_Supprimer.Location = new System.Drawing.Point(311, 312);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(118, 30);
            this.btn_Supprimer.TabIndex = 7;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // txt_NomPrenom
            // 
            this.txt_NomPrenom.Location = new System.Drawing.Point(138, 28);
            this.txt_NomPrenom.Name = "txt_NomPrenom";
            this.txt_NomPrenom.Size = new System.Drawing.Size(100, 23);
            this.txt_NomPrenom.TabIndex = 8;
            this.txt_NomPrenom.TextChanged += new System.EventHandler(this.txt_NomPrenom_TextChanged);
            this.txt_NomPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NomPrenom_KeyPress);
            // 
            // txt_NoteDS
            // 
            this.txt_NoteDS.Location = new System.Drawing.Point(139, 82);
            this.txt_NoteDS.Name = "txt_NoteDS";
            this.txt_NoteDS.Size = new System.Drawing.Size(99, 23);
            this.txt_NoteDS.TabIndex = 9;
            this.txt_NoteDS.TextChanged += new System.EventHandler(this.txt_NoteDS_TextChanged);
            this.txt_NoteDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteDS_KeyPress);
            // 
            // txt_NoteExamen
            // 
            this.txt_NoteExamen.Location = new System.Drawing.Point(139, 136);
            this.txt_NoteExamen.Name = "txt_NoteExamen";
            this.txt_NoteExamen.Size = new System.Drawing.Size(99, 23);
            this.txt_NoteExamen.TabIndex = 10;
            this.txt_NoteExamen.TextChanged += new System.EventHandler(this.txt_NoteExamen_TextChanged);
            this.txt_NoteExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteExamen_KeyPress);
            // 
            // txt_NoteNP
            // 
            this.txt_NoteNP.Location = new System.Drawing.Point(139, 194);
            this.txt_NoteNP.Name = "txt_NoteNP";
            this.txt_NoteNP.Size = new System.Drawing.Size(99, 23);
            this.txt_NoteNP.TabIndex = 11;
            this.txt_NoteNP.TextChanged += new System.EventHandler(this.txt_NoteNP_TextChanged);
            this.txt_NoteNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteNP_KeyPress);
            // 
            // txt_Moyenne
            // 
            this.txt_Moyenne.Enabled = false;
            this.txt_Moyenne.Location = new System.Drawing.Point(139, 249);
            this.txt_Moyenne.Name = "txt_Moyenne";
            this.txt_Moyenne.Size = new System.Drawing.Size(99, 23);
            this.txt_Moyenne.TabIndex = 12;
            this.txt_Moyenne.TextChanged += new System.EventHandler(this.txt_Moyenne_TextChanged);
            // 
            // lst_Moyenne
            // 
            this.lst_Moyenne.FormattingEnabled = true;
            this.lst_Moyenne.ItemHeight = 15;
            this.lst_Moyenne.Location = new System.Drawing.Point(273, 28);
            this.lst_Moyenne.Name = "lst_Moyenne";
            this.lst_Moyenne.Size = new System.Drawing.Size(286, 244);
            this.lst_Moyenne.TabIndex = 13;
            this.lst_Moyenne.SelectedIndexChanged += new System.EventHandler(this.lst_Moyenne_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.lst_Moyenne);
            this.Controls.Add(this.txt_Moyenne);
            this.Controls.Add(this.txt_NoteNP);
            this.Controls.Add(this.txt_NoteExamen);
            this.Controls.Add(this.txt_NoteDS);
            this.Controls.Add(this.txt_NomPrenom);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Calculer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Calculer;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.TextBox txt_NomPrenom;
        private System.Windows.Forms.TextBox txt_NoteDS;
        private System.Windows.Forms.TextBox txt_NoteExamen;
        private System.Windows.Forms.TextBox txt_NoteNP;
        private System.Windows.Forms.TextBox txt_Moyenne;
        private System.Windows.Forms.ListBox lst_Moyenne;
    }
}

