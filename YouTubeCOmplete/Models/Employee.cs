using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YouTubeCOmplete.Models
{
    [Table("TblEmployee")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
    }
}