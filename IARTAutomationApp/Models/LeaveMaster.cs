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
    
    public partial class LeaveMaster
    {
        public int LeaveId { get; set; }
        public int LeaveTypeId { get; set; }
        public int LeaveCount { get; set; }
        public string CalenderYear { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsCreated { get; set; }
        public Nullable<int> CustomerId { get; set; }
    }
}
