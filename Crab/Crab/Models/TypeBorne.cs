using System;
using System.Collections.Generic;
using System.Text;

namespace Crab.Models
{
    class TypeBorne
    {
        #region Attributs
        private int codeTypeBorne;
        private int dureeRevision;
        private int nbJoursEntreRevisions;
        private int nbUnitesEntreRevisions;
        #endregion
        #region Constructeur
        public TypeBorne(int codeTypeBorne, int dureeRevision, int nbJoursEntreRevisions, int nbUnitesEntreRevisions)
        {
            this.CodeTypeBorne = codeTypeBorne;
            this.DureeRevision = dureeRevision;
            this.NbJoursEntreRevisions = nbJoursEntreRevisions;
            this.NbUnitesEntreRevisions = nbUnitesEntreRevisions;
        }
        #endregion
        #region Getters-Setters
        public int CodeTypeBorne { get => codeTypeBorne; set => codeTypeBorne = value; }
        public int DureeRevision { get => dureeRevision; set => dureeRevision = value; }
        public int NbJoursEntreRevisions { get => nbJoursEntreRevisions; set => nbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => nbUnitesEntreRevisions; set => nbUnitesEntreRevisions = value; }
        #endregion
        #region Méthodes
        public int getDureeRevision()
        {
            return this.dureeRevision;
        }
        public int getNbJoursEntreRevisions()
        {
            return this.nbJoursEntreRevisions;
        }
        public int getNbUnitesRevisions()
        {
            return this.nbUnitesEntreRevisions;
        }
        #endregion
    }
}
