using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace summer19.Model
{
    public class Filter
    {
        [Key]
        public string Req { get; set; }
        public string Pos { get; set; }
        public string Loc { get; set; }
    }
}
