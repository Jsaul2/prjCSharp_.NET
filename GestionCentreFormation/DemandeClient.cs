//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCentreFormation
{
    using System;
    using System.Collections.Generic;
    
    public partial class DemandeClient
    {
        public int Identifiant { get; set; }
        public System.DateTime DateDemande { get; set; }
        public Nullable<System.DateTime> DateTraitement { get; set; }
        public int IdFormation { get; set; }
        public int IdClient { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Formation Formation { get; set; }
    }
}
