//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SingupWithLoginMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is Required Field")]
        [DisplayName("First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required Field")]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Gender is Required Field")]
        [DisplayName("Gender")]
        public string gnender { get; set; }

        [Required(ErrorMessage = "Age is Required Field")]
        [DisplayName("Age")]
        public int age { get; set; }

        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage ="Invalid Email")]
        [Required(ErrorMessage = "Email is Required Field")]
        [DisplayName("Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "User Name is Required Field")]
        [DisplayName("User Name")]
        public string usaername { get; set; }

        [Required(ErrorMessage = "Password is Required Feild")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required Feild")]
        [DisplayName("Confirm Password")]
        [Compare("password",ErrorMessage ="Password is not Identical")]
        public string confirm_password { get; set; }
    }
}
