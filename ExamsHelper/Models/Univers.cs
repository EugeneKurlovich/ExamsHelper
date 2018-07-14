﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExamsHelper.Models
{
    public class Univers
    {
        [Key]
        public Int32 Id { get; set; }

        public string NameOfUniver { get; set; }
        
        public List<Faculties> Faculties { get; set; }
    }
}
