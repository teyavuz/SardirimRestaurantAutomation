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
    
    public partial class Stock
    {
        public int StockID { get; set; }
        public int MainProductID { get; set; }
        public int UnitTypesID { get; set; }
        public Nullable<decimal> Value { get; set; }
    
        public virtual MainProduct MainProduct { get; set; }
        public virtual UnitType UnitType { get; set; }
    }
}
