//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Contacts
    {

        public int contactID { get; set; }

        //[Required(ErrorMessage = "First Name is required")]
        //[DisplayName("First Name")]
        public string firstName { get; set; }


        //[Required(ErrorMessage = "Last Name is required")]
        //[DisplayName("Last Name")]
        public string lastName { get; set; }

        //[Required(ErrorMessage = "E-mail is required")]
        //[DisplayName("E-mail")]
        public string e_mail { get; set; }

        //[DisplayName("Phone No")]
        public string phoneNo { get; set; }

        //[DisplayName("Unit No")]
        public Nullable<int> unitNo { get; set; }

        //[DisplayName("Street Name")]
        public string streetName { get; set; }

        //[DisplayName("Suburb")]
        public string suburb { get; set; }

        //[DisplayName("State")]
        public string state { get; set; }

        //[DisplayName("Company Name")]
        public string company { get; set; }

        //[DisplayName("Street No")]
        public Nullable<int> streetNo { get; set; }

        //[DisplayName("Country")]
        public Nullable<int> countryId { get; set; }
    
        public virtual tbl_Countries tbl_Countries { get; set; }
    }
}
