using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebForms.Models
{
    public class Animal
    {

        [ScaffoldColumn(false)]
        public int AnimalID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string AnimalName { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public double? TicketPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}