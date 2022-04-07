using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace av.Models{
    public class Teacher{
        [Key]
        public int TeacherId {get;set;}

        public string? Teacher_Name{get;set;}

        public string? Subject{get;set;}

        [Range(1,5)]
        public int credits{get;set;}
    }
}