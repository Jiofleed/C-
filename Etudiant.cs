using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Etudiant
    {
        private string nom;
        private int Datenaissance;
        private int taille;

        public Etudiant(string unEtu,int uneDatenaissance, int unetaille)
        {
            this.nom = unEtu;
            this.Datenaissance = uneDatenaissance;
            this.taille = unetaille;
        }

        public void travailler()
        {
            Console.WriteLine(this.nom + " se met au travail");
        }

        public void seReposer()
        {
            Console.WriteLine(this.nom + " se repose");
        }
    }
}

