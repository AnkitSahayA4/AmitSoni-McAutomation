﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IARTDBNEWEntities : DbContext
    {
        public IARTDBNEWEntities()
            : base("name=IARTDBNEWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AllowanceMaster> AllowanceMasters { get; set; }
        public virtual DbSet<AnnualLeave> AnnualLeaves { get; set; }
        public virtual DbSet<BankMaster> BankMasters { get; set; }
        public virtual DbSet<BankTypeMaster> BankTypeMasters { get; set; }
        public virtual DbSet<CadreMaster> CadreMasters { get; set; }
        public virtual DbSet<CasualLeave> CasualLeaves { get; set; }
        public virtual DbSet<CentralStore> CentralStores { get; set; }
        public virtual DbSet<ChemicalStore> ChemicalStores { get; set; }
        public virtual DbSet<CityMaster> CityMasters { get; set; }
        public virtual DbSet<DeductionsMaster> DeductionsMasters { get; set; }
        public virtual DbSet<EmpAIAssociation> EmpAIAssociations { get; set; }
        public virtual DbSet<EmpAIConference> EmpAIConferences { get; set; }
        public virtual DbSet<EmployeeAI> EmployeeAIs { get; set; }
        public virtual DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }
        public virtual DbSet<EmployeeGI> EmployeeGIs { get; set; }
        public virtual DbSet<EmployeeMI> EmployeeMIs { get; set; }
        public virtual DbSet<EmployeePI> EmployeePIs { get; set; }
        public virtual DbSet<EmployeeSI> EmployeeSIs { get; set; }
        public virtual DbSet<FertilizerStore> FertilizerStores { get; set; }
        public virtual DbSet<GraduateAttachmentForm> GraduateAttachmentForms { get; set; }
        public virtual DbSet<LeaveApplication> LeaveApplications { get; set; }
        public virtual DbSet<LeaveLedger> LeaveLedgers { get; set; }
        public virtual DbSet<LeaveMaster> LeaveMasters { get; set; }
        public virtual DbSet<LeaveRoasterJuniorStaff> LeaveRoasterJuniorStaffs { get; set; }
        public virtual DbSet<LeaveTypeMaster> LeaveTypeMasters { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<NyscFinalClearance> NyscFinalClearances { get; set; }
        public virtual DbSet<NyscMonthlyClearance> NyscMonthlyClearances { get; set; }
        public virtual DbSet<PFAMaster> PFAMasters { get; set; }
        public virtual DbSet<PrequalificationScoring> PrequalificationScorings { get; set; }
        public virtual DbSet<PrintForm> PrintForms { get; set; }
        public virtual DbSet<ProgrammeMaster> ProgrammeMasters { get; set; }
        public virtual DbSet<QualificationMaster> QualificationMasters { get; set; }
        public virtual DbSet<RankMaster> RankMasters { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<SalaryPayment> SalaryPayments { get; set; }
        public virtual DbSet<SalaryStructureMaster> SalaryStructureMasters { get; set; }
        public virtual DbSet<SectionMaster> SectionMasters { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
        public virtual DbSet<StationaryStore> StationaryStores { get; set; }
        public virtual DbSet<StationMaster> StationMasters { get; set; }
        public virtual DbSet<TendererInformation> TendererInformations { get; set; }
        public virtual DbSet<TenderOpening> TenderOpenings { get; set; }
        public virtual DbSet<UnitResearchMaster> UnitResearchMasters { get; set; }
        public virtual DbSet<UnitServicesMaster> UnitServicesMasters { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<StoreMaster> StoreMasters { get; set; }
        public virtual DbSet<StatusMaster> StatusMasters { get; set; }
        public virtual DbSet<ItemMaster> ItemMasters { get; set; }
        public virtual DbSet<VendorMaster> VendorMasters { get; set; }
        public virtual DbSet<COUNTRYLIST> COUNTRYLISTs { get; set; }
        public virtual DbSet<ClassMaster> ClassMasters { get; set; }
        public virtual DbSet<UomMaster> UomMasters { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<StockMaster> StockMasters { get; set; }
        public virtual DbSet<CrivVoucher> CrivVouchers { get; set; }
        public virtual DbSet<StoreReciptVoucher> StoreReciptVouchers { get; set; }
        public virtual DbSet<StoreCreditVoucher> StoreCreditVouchers { get; set; }
        public virtual DbSet<StoreGateVoucher> StoreGateVouchers { get; set; }
        public virtual DbSet<StoreTallyVoucher> StoreTallyVouchers { get; set; }
        public virtual DbSet<SuperAdmin> SuperAdmins { get; set; }
    }
}
