//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniSpa.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovieGenre
    {
        public MovieGenre()
        {
            this.MovieDvds = new HashSet<MovieDvd>();
        }
    
        public int MovieGenreId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<MovieDvd> MovieDvds { get; set; }
    }
}
