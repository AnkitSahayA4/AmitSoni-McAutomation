//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IARTAutomationApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreMaster
    {
        public int RecordId { get; set; }
        public int StoreNumber { get; set; }
        public string StoreName { get; set; }
        public string StoreDesc { get; set; }
        public string StoreImgName { get; set; }
        public Nullable<int> StoreStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> CustomerId { get; set; }
    }
}
