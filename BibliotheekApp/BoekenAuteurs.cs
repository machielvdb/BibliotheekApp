//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotheekApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class BoekenAuteurs
    {
        public int Id { get; set; }
        public Nullable<int> BoekId { get; set; }
        public Nullable<int> AuteurId { get; set; }

        public BoekenAuteurs()
        {

        }

        public BoekenAuteurs(int boekId, int auteurId)
        {
            this.BoekId = boekId;
            this.AuteurId = auteurId;
        }
    }
}
