//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Part6
{
    using System;
    using System.Collections.Generic;
    
    public partial class prodazba
    {
        public int id_klient { get; set; }
        public int id_karti { get; set; }
        public string datum_prodazba { get; set; }
    
        public virtual karti karti { get; set; }
        public virtual klient klient { get; set; }
    }
}
