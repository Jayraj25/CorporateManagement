using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace summer19.Model
{
    public partial class Requirements
    {
        public int Id { get; set; }
        public string Departement { get; set; }
        public string Position { get; set; }
        public int NoPosition { get; set; }
        public string Skills { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
