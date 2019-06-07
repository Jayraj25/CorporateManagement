using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace summer19.Model
{
    public partial class Candidate
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        [Required]
        public string Firstname { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Middlename { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Lastname { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Jobtitle { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Email { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Cell { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Home { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Fax { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Address1 { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Please enter 3 to 100")]
        public string Address2 { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter 3 to 30")]
        public string City { get; set; }


        public int Zip { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Departement { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Country { get; set; }

        [StringLength(10, MinimumLength = 2, ErrorMessage = "Please enter 3 to 10")]
        public string Hire { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Comptetenices { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Jobcategory { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Source { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Please enter 3 to 15")]
        public string Resumeupload { get; set; }

        public string Resumes { get; set; }
        public string Status { get; set; }
        public string Feedback { get; set; }
    }
}
