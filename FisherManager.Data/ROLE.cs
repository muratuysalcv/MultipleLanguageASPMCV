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
    
    public partial class ROLE
    {
        public ROLE()
        {
            this.USER_ACCOUNT = new HashSet<USER_ACCOUNT>();
        }
    
        public int ROLE_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETE { get; set; }
        public System.DateTime DATE_CREATE { get; set; }
        public Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public Nullable<System.DateTime> DATE_DELETE { get; set; }
        public string SYSTEM_CODE_TITLE { get; set; }
        public string SYSTEM_CODE_DESCRIPTION { get; set; }
    
        public virtual ICollection<USER_ACCOUNT> USER_ACCOUNT { get; set; }
    }
}