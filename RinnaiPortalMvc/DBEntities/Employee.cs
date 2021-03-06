//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RinnaiPortalMvc.DBEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Department = new HashSet<Department>();
            this.Department1 = new HashSet<Department>();
            this.SignAgent = new HashSet<SignAgent>();
            this.SignForm_Detail = new HashSet<SignForm_Detail>();
            this.SignForm_Main = new HashSet<SignForm_Main>();
        }
    
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentID_FK { get; set; }
        public string CostDepartmentID { get; set; }
        public string AgentID { get; set; }
        public bool Disabled { get; set; }
        public Nullable<System.DateTime> DisabledDate { get; set; }
        public string ADAccount { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Modifier { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string AccessType { get; set; }
        public string NationalType { get; set; }
        public string SexType { get; set; }
    
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Department> Department1 { get; set; }
        public virtual Department Department2 { get; set; }
        public virtual ICollection<SignAgent> SignAgent { get; set; }
        public virtual ICollection<SignForm_Detail> SignForm_Detail { get; set; }
        public virtual ICollection<SignForm_Main> SignForm_Main { get; set; }
    }
}
