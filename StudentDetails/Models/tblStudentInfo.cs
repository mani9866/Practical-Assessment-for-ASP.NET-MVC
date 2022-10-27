//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models
{

    
    public partial class tblStudentInfo
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string studentName { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        [MinLength(10, ErrorMessage = "mobile number contains  10 digits")]
        public string studentMobile { get; set; }

        [Required]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string studentAddress { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string studentDept { get; set; }
    }
}
