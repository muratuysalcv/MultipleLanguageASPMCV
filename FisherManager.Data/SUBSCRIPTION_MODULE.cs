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
    
    public partial class SUBSCRIPTION_MODULE
    {
        public int ID { get; set; }
        public int SUBSCRIPTION_ID { get; set; }
        public int MODULE_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETE { get; set; }
        public System.DateTime DATE_CREATE { get; set; }
        public Nullable<System.DateTime> DATE_DELETE { get; set; }
        public Nullable<System.DateTime> DATE_UPDATE { get; set; }
    
        public virtual MODULE MODULE { get; set; }
        public virtual SUBSCRIPTION SUBSCRIPTION { get; set; }
    }
}
