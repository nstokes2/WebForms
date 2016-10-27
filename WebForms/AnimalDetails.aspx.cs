using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.Models;
using System.Web.ModelBinding;

namespace WebForms
{
    public partial class AnimalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Animal> GetAnimal([QueryString("animalID")] int? animalID)
        {
            var _db = new WebForms.Models.AnimalContext();
            IQueryable<Animal> query = _db.Animals;
            if (animalID.HasValue && animalID > 0)
            {
                query = query.Where(p => p.AnimalID == animalID);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}