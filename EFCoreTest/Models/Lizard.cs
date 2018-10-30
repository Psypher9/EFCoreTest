using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest.Models
{
    public class Lizard
    {
        public Lizard() { }

        [Key]
        public int Id { get; set; }
        public string ScaleColor { get; set; }
        public string EyeColor { get; set; }
    }
}
