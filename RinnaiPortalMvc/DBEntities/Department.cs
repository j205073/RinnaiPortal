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
    
    public partial class Department
    {
        public Department()
        {
            this.Employee2 = new HashSet<Employee>();
            this.SignForm_Main = new HashSet<SignForm_Main>();
            this.SignType = new HashSet<SignType>();
        }
    
        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string ChiefID_FK { get; set; }
        public string UpperDepartmentID { get; set; }
        public int DepartmentLevel { get; set; }
        public string FilingEmployeeID_FK { get; set; }
        public string Virtual { get; set; }
        public Nullable<bool> Disabled { get; set; }
        public Nullable<System.DateTime> DisabledDate { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Modifier { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual ICollection<Employee> Employee2 { get; set; }
        public virtual ICollection<SignForm_Main> SignForm_Main { get; set; }
        public virtual ICollection<SignType> SignType { get; set; }
    }
}
