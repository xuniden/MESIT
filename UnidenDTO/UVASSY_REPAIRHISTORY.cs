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
    
    public partial class UVASSY_REPAIRHISTORY
    {
        public long ID { get; set; }
        public string Model { get; set; }
        public string RepairCode { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorPosition { get; set; }
        public string CauseCode { get; set; }
        public string DeptCode { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Remark { get; set; }
        public string PCBType { get; set; }
    }
}
