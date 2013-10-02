using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            int Datenaissance;
            int taille;
            Console.WriteLine("Saisissez votre nom : ");
            nom = Console.ReadLine();
            Console.WriteLine("Saisir votre date de naissance : ");
            Datenaissance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir votre taille : ");
            taille = Convert.ToInt32(Console.ReadLine());

            Etudiant unEtudiant = new Etudiant(nom,Datenaissance,taille);

            unEtudiant.travailler();
            unEtudiant.seReposer();
            Console.Read();
        }
        
    }
}
