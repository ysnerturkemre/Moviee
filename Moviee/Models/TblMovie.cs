//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moviee.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblMovie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public Nullable<int> MovieYear { get; set; }
        public Nullable<int> Category { get; set; }
    
        public virtual TblKategori TblKategori { get; set; }
    }
}
