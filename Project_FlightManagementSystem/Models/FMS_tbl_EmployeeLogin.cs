//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_FlightManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class FMS_tbl_EmployeeLogin
    {
        public int EmployeeId { get; set; }
        [Display(Name ="User Name:")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Addres { get; set; }
        public Nullable<int> YearsOfExperiance { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public Nullable<decimal> CTC { get; set; }
        [Display(Name ="Password:")]
        [DataType(DataType.Password)]
        public string Pasword { get; set; }
        public string Roles { get; set; }
        public string place { get; set; }
        public string stats { get; set; }
    }
}
