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
    
    public partial class PACKAGE
    {
        public PACKAGE()
        {
            this.PACKAGE_CALCULATION = new HashSet<PACKAGE_CALCULATION>();
        }
    
        public string PACKAGE_CODE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public bool ACTIVE { get; set; }
    
        public virtual ICollection<PACKAGE_CALCULATION> PACKAGE_CALCULATION { get; set; }
    }
}
