//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sardirim_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounting
    {
        public int AccountigID { get; set; }
        public int SourceID { get; set; }
        public decimal Amount { get; set; }
        public short Factor { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreatorID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdaterID { get; set; }
    
        public virtual SourceType SourceType { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
    }
}