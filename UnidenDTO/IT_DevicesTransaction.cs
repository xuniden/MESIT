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
    
    public partial class IT_DevicesTransaction
    {
        public long ID { get; set; }
        public string IssueReturn { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string MaTB { get; set; }
        public string FromDept { get; set; }
        public string FromLoc { get; set; }
        public string ToDept { get; set; }
        public string ToLoc { get; set; }
        public string IPAddress { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Remark { get; set; }
    
        public virtual IT_DevicesManagement IT_DevicesManagement { get; set; }
    }
}
