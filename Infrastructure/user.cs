//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int id { get; set; }
        public string userame { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> createddate { get; set; }
        public Nullable<bool> isActive { get; set; }
    }
}
