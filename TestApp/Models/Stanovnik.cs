using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Stanovnik
    {
        public int Id { get; set; }
        public int GradId { get; set; }
        [Required]
        public string ImeStanovnika { get; set; }
        [Required]
        public string PrezimeStanovnika { get; set; }
        public string UlicaStanovnika { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime DatumRodenja { get; set; }
        public Grad Grad { get; set; }
    }
}
