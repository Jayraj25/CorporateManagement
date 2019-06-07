using System;
using System.Collections.Generic;

namespace summer19.Model
{
    public partial class Candidate
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Jobtitle { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string Home { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? Zip { get; set; }
        public string Departement { get; set; }
        public string Country { get; set; }
        public string Hire { get; set; }
        public string Comptetenices { get; set; }
        public string Jobcategory { get; set; }
        public string Source { get; set; }
        public string Resumeupload { get; set; }
        public string Resumes { get; set; }
        public string Status { get; set; }
        public string Feedback { get; set; }
    }
}
