

namespace IARTAutomationApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnnualLeaveMap
    {
        public int Id { get; set; }
        public Nullable<int> EmployeeCode { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Maritalstatus { get; set; }
        public string Nationality { get; set; }
        public string PhoneNo { get; set; }
        public string Fileno { get; set; }
        public string PresentStatus { get; set; }
        public string Salaryperannum { get; set; }
        public string Proposedannualleave { get; set; }
        public Nullable<System.DateTime> LeavefromDate { get; set; }
        public Nullable<System.DateTime> LeavetoDate { get; set; }
        public string Totalworkingday { get; set; }
        public string IsLeave { get; set; }
        public Nullable<System.DateTime> IsLeavefromDate { get; set; }
        public Nullable<System.DateTime> IsLeavetoDate { get; set; }
        public string OutstandingLeaveDays { get; set; }
        public string IsPublicService { get; set; }
        public string IsHOD { get; set; }
        public string ActOfficer { get; set; }
        public string IApprove { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual EmployeeGI EmployeeGI { get; set; }
        public virtual EmployeeGI EmployeeGI1 { get; set; }
    }
}
