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
    
    public partial class Auteurs
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public Auteurs()
        {

        }

        public Auteurs(string voornaam, string achternaam)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
        }

        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }
    }
}