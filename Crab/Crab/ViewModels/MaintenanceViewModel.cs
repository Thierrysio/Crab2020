using Crab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace Crab.ViewModels
{
    class MaintenanceViewModel : INotifyPropertyChanged
    {
        #region attributs
        private int _nombreVisites;

        #endregion
        #region Constructeurs
        public MaintenanceViewModel()
        {
            new Technicien(1, "disney", "riri");
            new Technicien(2, "disney", "fifi");

            TypeBorne tb1 = new TypeBorne(1, 25, 30, 100);
            TypeBorne tb2 = new TypeBorne(2, 35, 40, 120);

            Station st1 = new Station(1, "Lannion");
            st1.LesBornes.Add(new Borne(1, new DateTime(2020, 05, 01), 120, tb1));
            st1.LesBornes.Add(new Borne(2, new DateTime(2020, 05, 01), 120, tb2));
            st1.LesBornes.Add(new Borne(3, new DateTime(2020, 05, 01), 120, tb2));
            st1.LesBornes.Add(new Borne(4, new DateTime(2020, 05, 01), 120, tb1));
            Station st2 = new Station(2, "Rennes");
            st2.LesBornes.Add(new Borne(5, new DateTime(2020, 10, 01), 10, tb1));
            st2.LesBornes.Add(new Borne(6, new DateTime(2020, 05, 01), 120, tb2));
            st2.LesBornes.Add(new Borne(7, new DateTime(2020, 05, 01), 120, tb2));
            st2.LesBornes.Add(new Borne(8, new DateTime(2020, 05, 01), 120, tb1));
            Station st3 = new Station(3, "Paimpol");
            st3.LesBornes.Add(new Borne(9, new DateTime(2020, 10, 01), 10, tb1));
            st3.LesBornes.Add(new Borne(10, new DateTime(2020, 10, 01), 10, tb2));
            st3.LesBornes.Add(new Borne(11, new DateTime(2020, 05, 01), 120, tb2));
            st3.LesBornes.Add(new Borne(12, new DateTime(2020, 05, 01), 120, tb1));
            Station st4 = new Station(4, "Treguier");
            st4.LesBornes.Add(new Borne(13, new DateTime(2020, 10, 01), 10, tb1));
            st4.LesBornes.Add(new Borne(14, new DateTime(2020, 10, 01), 10, tb2));
            st4.LesBornes.Add(new Borne(15, new DateTime(2020, 10, 01), 10, tb2));
            st4.LesBornes.Add(new Borne(16, new DateTime(2020, 10, 01), 10, tb1));

            Maintenance m1 = new Maintenance();
            m1.Reviser();
           
            NombreVisites = m1.LesVisites.Count;
        
        }
        #endregion
        #region Getters Setters
        public int NombreVisites
        {
            get
            {
                return _nombreVisites;
            }
            set
            {
                if (_nombreVisites != value)
                {
                    _nombreVisites = value;
                    OnPropertyChanged(nameof(NombreVisites));

                }
            }
        }
        #endregion
        #region notifications

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
