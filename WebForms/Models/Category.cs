using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebForms.Models
{
    public class Category
    {

        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "General Animal Description")]
        public string Description { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}