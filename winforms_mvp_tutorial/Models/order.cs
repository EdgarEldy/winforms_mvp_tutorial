//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winforms_mvp_tutorial.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<double> total { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual product product { get; set; }
    }
}
