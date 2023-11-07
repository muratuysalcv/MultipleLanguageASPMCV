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
    
    public partial class COMPANY_PAYMENT
    {
        public COMPANY_PAYMENT()
        {
            this.COMPANY_PAYMENT_TRANSACTION = new HashSet<COMPANY_PAYMENT_TRANSACTION>();
        }
    
        public int COMPANY_PAYMENT_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETE { get; set; }
        public System.DateTime DATE_CREATE { get; set; }
        public Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public Nullable<System.DateTime> DATE_DELETE { get; set; }
        public int COMPANY_ACCOUNTING_ID { get; set; }
        public System.DateTime LAST_PAYMENT_DATE { get; set; }
        public decimal TOTAL_DEBT { get; set; }
        public decimal PAID { get; set; }
        public int CURRENCY_TYPE { get; set; }
        public bool IS_COMPLETE { get; set; }
        public int COMPANY_SUBSCRIPTION_ID { get; set; }
    
        public virtual COMPANY_ACCOUNTING COMPANY_ACCOUNTING { get; set; }
        public virtual ICollection<COMPANY_PAYMENT_TRANSACTION> COMPANY_PAYMENT_TRANSACTION { get; set; }
    }
}
