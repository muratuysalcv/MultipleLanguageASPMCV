//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FisherManager.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class LANGUAGE
    {
        public LANGUAGE()
        {
            this.LANGUAGE_RES = new HashSet<LANGUAGE_RES>();
            this.MENU = new HashSet<MENU>();
        }
    
        public string LANGUAGE_CODE { get; set; }
        public string NAME { get; set; }
        public int DEFAULT_CURRENCY_CODE { get; set; }
    
        public virtual ICollection<LANGUAGE_RES> LANGUAGE_RES { get; set; }
        public virtual ICollection<MENU> MENU { get; set; }
    }
}
