using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Grad
    {
        public int Id { get; set; }
        [Display(Name ="Ime Grada")]
        [Required]
        public string ImeGrada { get; set; }
        [Display(Name = "Broj Stanovnika")]
        public int BrojStanovnika { get; set; }
        [Display(Name = "Ime Gradonacelnika")]
        public string ImeGradonacelnika { get; set; }
        [Display(Name = "Broj Skola")]
        public int BrojSkola { get; set; }
        [Display(Name = "Proracun Grada")]
        public double ProracunGrada { get; set; }
        [Required]
        public string Drzava { get; set; }
    }
}