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
    
    public partial class COMPANY
    {
        public COMPANY()
        {
            this.COMPANY_ACCOUNTING = new HashSet<COMPANY_ACCOUNTING>();
            this.COMPANY_PARAMETER = new HashSet<COMPANY_PARAMETER>();
            this.COMPANY_SUBSCRIPTION = new HashSet<COMPANY_SUBSCRIPTION>();
            this.USER_ACCOUNT = new HashSet<USER_ACCOUNT>();
        }
    
        public int COMPANY_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETE { get; set; }
        public System.DateTime DATE_CREATE { get; set; }
        public Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public Nullable<System.DateTime> DATE_DELETE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<bool> IS_ROOT { get; set; }
        public string COUNTRY { get; set; }
        public string CITY { get; set; }
        public string DISTRICT { get; set; }
        public string TAX_NUMBER { get; set; }
        public string ADDRESS { get; set; }
        public string TAX_OFFICE { get; set; }
        public string PRODUCTION_CAPACITY { get; set; }
    
        public virtual ICollection<COMPANY_ACCOUNTING> COMPANY_ACCOUNTING { get; set; }
        public virtual ICollection<COMPANY_PARAMETER> COMPANY_PARAMETER { get; set; }
        public virtual ICollection<COMPANY_SUBSCRIPTION> COMPANY_SUBSCRIPTION { get; set; }
        public virtual ICollection<USER_ACCOUNT> USER_ACCOUNT { get; set; }
    }
}