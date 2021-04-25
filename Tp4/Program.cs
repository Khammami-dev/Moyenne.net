using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp4
{
     class Etudiant
    {
        // attributs
        private String nomPrenom;
        private  double note_ds;
        private double note_exam;
        private double note_np;
       
        // méthode
        public void Initialise(string nom, double ds, double exam, double np)
        {
            this.nomPrenom = nom;
            this.note_ds = ds;
            this.note_exam = exam;
            this.note_np = np;
            
        }
        // méthode
        public void Identifie()
        {
            Console.WriteLine("[{0}, {1}, {2}, {3}, {4}]", nomPrenom, note_ds, note_exam, note_np);
        }
        public Etudiant(String nom, double ds, double exam, double np)
        {
            Initialise(nom, ds, exam, np);
        }
        public double calculer(double ds, double exam, double np)
        {
            ds = ds * 0.3 ;
            exam = exam * 0.5;
            np = np * 0.2;

            double moy = (double)(ds+exam+np);
            return moy;
        }
        


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
