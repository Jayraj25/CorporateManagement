using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace summer19.Model
{
    public partial class DataFile
    {
        [Key]
        public int Id { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
    }
}
