//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PhoneNo { get; set; }
        public string AlternatePhoneNo { get; set; }
        public string Address { get; set; }
        public string IdProof { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> PostalCode { get; set; }
        public string Fax { get; set; }
        public string ArrivalInfo { get; set; }
        public string Comments { get; set; }
        public string Nationality { get; set; }
        public string PassportNo { get; set; }
        public Nullable<int> PassportCountryId { get; set; }
        public Nullable<System.DateTime> ExpiryDateOfPassport { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
