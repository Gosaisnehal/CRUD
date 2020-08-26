using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD
{
    public class tbl_ContactsValidation
    {
        public int contactID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        public string firstName { get; set; }


        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "E-mail is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                ErrorMessage ="Email is not valid. e.g. xxx@domain.com")]
        [DisplayName("E-mail")]
        public string e_mail { get; set; }

        [Required(ErrorMessage = "Phone no is required")]
        [RegularExpression (@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$",
                   ErrorMessage = "Entered phone number format is not valid.  <br /> Enter 10 digit phone number e.g. 0xxx xxx xxx ")]
        [DisplayName("Phone No")]
        public string phoneNo { get; set; }
     

        [DisplayName("Unit No")]
        public Nullable<int> unitNo { get; set; }

        [DisplayName("Street Name")]
        public string streetName { get; set; }

        [DisplayName("Suburb")]
        public string suburb { get; set; }

        [DisplayName("State")]
        public string state { get; set; }

        [DisplayName("Company Name")]
        public string company { get; set; }

        [DisplayName("Street No")]
        public Nullable<int> streetNo { get; set; }

        [DisplayName("Country")]
        public Nullable<int> countryId { get; set; }

    }
    [MetadataType(typeof(tbl_ContactsValidation))]
    public partial class tbl_Contacts
    {
    }
}