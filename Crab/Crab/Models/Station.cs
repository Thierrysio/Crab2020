using System;
using System.Collections.Generic;
using System.Text;

namespace Crab.Models
{
    class Station
    {
        #region Attributs
        public static List<Station> CollClasseStation = new List<Station>();
        private int idStation;
        private string libelleEmplacement;
        private List<Borne> lesBornes;
        #endregion
        #region Constructeur
        public Station(int idStation, string libelleEmplacement)
        {
            this.IdStation = idStation;
            this.LibelleEmplacement = libelleEmplacement;
            this.LesBornes = new List<Borne>();
            CollClasseStation.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int IdStation { get => idStation; set => idStation = value; }
        public string LibelleEmplacement { get => libelleEmplacement; set => libelleEmplacement = value; }
        public List<Borne> LesBornes { get => lesBornes; set => lesBornes = value; }
        #endregion
        #region Méthodes
        public int getId()
        {
            return this.idStation;
        }
        public string getLibelleEmplacement()
        {
            return this.libelleEmplacement;
        }
        public Visite GetVisiteAFaire()
        {
            Visite v = null;
            List<Borne> mesBornes = new List<Borne>();
            foreach(Borne laBorne in this.lesBornes)
            {
              if(laBorne.estAReviser())  mesBornes.Add(laBorne);
            }

            if (mesBornes.Count > 0)
            {
                v = new Visite(this, mesBornes);
                
            }

          return v;

        }
        #endregion
    }
}
