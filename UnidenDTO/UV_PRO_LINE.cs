//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnidenDTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class UV_PRO_LINE
    {
        public long ID { get; set; }
        public string LineName { get; set; }
        public Nullable<long> DeptID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual UV_DEPT UV_DEPT { get; set; }
    }
}
