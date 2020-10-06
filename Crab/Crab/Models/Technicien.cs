using System;
using System.Collections.Generic;
using System.Text;

namespace Crab.Models
{
    class Technicien
    {
        #region Attributs
        public static List<Technicien> CollClasseTechnicien = new List<Technicien>();
        private int matricule;
        private string nom;
        private string prenom;
        private List<Visite> lesVisites;
        #endregion
        #region Constructeur
        public Technicien(int matricule, string nom, string prenom)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.LesVisites = new List<Visite>();
            CollClasseTechnicien.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public List<Visite> LesVisites { get => lesVisites; set => lesVisites = value; }
        #endregion
        #region Méthodes
        public int getTempsOccupe()
        {
            int res = 0;
            foreach(Visite laVisite in this.lesVisites)
            {
                res += laVisite.getDureeTotal();
            }
            return res;
        }
        public void affecterVisite(Visite uneVisite)
        {
            uneVisite.changerEtat();
            uneVisite.getDureeTotal();
            this.lesVisites.Add(uneVisite);
        }
        public List<Visite> getLesVisites()
        {
            return this.lesVisites;
        }
        #endregion
    }
}
