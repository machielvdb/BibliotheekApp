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
    
    public partial class Genres
    {
        public int Id { get; set; }
        public string Genre { get; set; }

        public Genres()
        {

        }
        public Genres(string genre)
        {
            this.Genre = genre;
        }
        public override string ToString()
        {
            return Genre;
        }
    }
}