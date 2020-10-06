﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crab.Models
{
    class Maintenance
    {
        #region Attributs
        private List<Station> _lesStations;
        private List<Technicien> _lesTechniciens;
        private List<Visite> _lesVisites;
        public static List<Maintenance> collClasseMaintenance = new List<Maintenance>();


        #endregion
        #region Constructeur
        public Maintenance()
        {
            _lesTechniciens = Technicien.CollClasseTechnicien.ToList<Technicien>();
            _lesStations = Station.CollClasseStation.ToList<Station>();
            _lesVisites = new List<Visite>();
            collClasseMaintenance.Add(this);
        }
        #endregion
        #region Getters-Setters
        public List<Station> LesStations { get => _lesStations; set => _lesStations = value; }
        public List<Technicien> LesTechniciens { get => _lesTechniciens; set => _lesTechniciens = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }
        #endregion
        #region Méthodes
        public void Reviser()
        {
            foreach(Station uneStation in this.LesStations)
            {
                if (uneStation.GetVisiteAFaire() != null)
                {
                    this.LesVisites.Add(uneStation.GetVisiteAFaire());
                    
                }
            }
            this.AffecterVisites();
        }
        public void AffecterVisites()
        {
            Technicien t = this.LesTechniciens[0];
            foreach (Visite uneVisite in this.LesVisites)
            {
                foreach (Technicien unTechnicien in this.LesTechniciens)
                {
                    if (unTechnicien.getLesVisites().Count < t.getLesVisites().Count)
                    {
                        t = unTechnicien;
                    }
                }
                t.affecterVisite(uneVisite);
            }
        }
        #endregion
    }
}
