//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApprovalTests.Tests.NHibernate
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Employee { get; set; }
        public string Status { get; set; }
    
        public virtual Employee Employee1 { get; set; }
    }
}
