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
    
    public partial class Uitgeverijen
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public Uitgeverijen()
        {

        }

        public Uitgeverijen(string naam)
        {
            this.Naam = naam;
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
