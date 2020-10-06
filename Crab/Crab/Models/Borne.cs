using System;
using System.Collections.Generic;
using System.Text;

namespace Crab.Models
{
    class Borne
    {
        #region Attributs
        public static List<Borne> CollClasseBorne = new List<Borne>();
        private int idBorne;
        private DateTime dateDerniereRevision;
        private int indiceCompteurUnites;
        private TypeBorne leType;
        #endregion
        #region Constructeur
        public Borne(int idBorne, DateTime dateDerniereRevision, int indiceCompteurUnites,TypeBorne unType)
        {
            this.idBorne = idBorne;
            this.dateDerniereRevision = dateDerniereRevision;
            this.indiceCompteurUnites = indiceCompteurUnites;
            this.leType = unType;
            CollClasseBorne.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int IdBorne { get => idBorne; set => idBorne = value; }
        public DateTime DateDerniereRevision { get => dateDerniereRevision; set => dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => indiceCompteurUnites; set => indiceCompteurUnites = value; }
        public TypeBorne LeType { get => leType; set => leType = value; }
        #endregion
        #region Méthodes
        public int getDureeRevision()
        {
            return this.LeType.getDureeRevision();
        }
        public bool estAReviser()
        {
            if((this.indiceCompteurUnites > this.LeType.getNbJoursEntreRevisions()) || ((int)(DateTime.Now - this.DateDerniereRevision).TotalDays > LeType.getNbUnitesRevisions()))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
