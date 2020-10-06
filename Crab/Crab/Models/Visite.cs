using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab.Models
{
    class Visite
    {
        #region Attributs
        public static List<Visite> CollClasseVisite = new List<Visite>();
        private string etat;
        private int dureeTotale;
        private Station laStation;
        private List<Borne> lesBornes;
        #endregion
        #region Constructeur
        public Visite(Station uneStation, List<Borne> lesBornesAVisiter)
        {
            this.Etat = "P";
            this.DureeTotale = 0;
            this.LaStation = uneStation;
            this.lesBornes = lesBornesAVisiter.ToList<Borne>();
            CollClasseVisite.Add(this);
        }
        #endregion
        #region Getters-Setters
        public string Etat { get => etat; set => etat = value; }
        public int DureeTotale { get => dureeTotale; set => dureeTotale = value; }
        public Station LaStation { get => laStation; set => laStation = value; }
        public List<Borne> LesBornes { get => lesBornes; set => lesBornes = value; }
        #endregion
        #region Méthodes

        public int getDureeTotal()
        {
            int res = 0;
            foreach (Borne laBorne in this.lesBornes)
            {
                res += laBorne.getDureeRevision();
            }
            return res;
        }
        public string getEtat()
        {
            return this.etat;
        }
        public void changerEtat()
        {
            this.etat = (this.etat == "P") ? "A" : "R";   
        }
        #endregion
    }
}
