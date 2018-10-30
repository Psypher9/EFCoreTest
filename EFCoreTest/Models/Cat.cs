using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest.Models
{
    public class Cat
    {
        public Cat() { }

        [Key]
        public int Id { get; set; }
        public string MeowStyle { get; set; }
        public string FavoriteTreat { get; set; }
    }
}
