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
    
    public partial class SMT_AOI_ERROR_RECORD
    {
        public long ID { get; set; }
        public string Program { get; set; }
        public string QRCode { get; set; }
        public string ErrorPosition { get; set; }
        public string ErrorPart { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDesc { get; set; }
        public Nullable<int> ErrorQty { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Model { get; set; }
        public string Lot { get; set; }
        public string Line { get; set; }
    }
}
