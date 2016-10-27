using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using WebForms.Models;

namespace WebForms
{
    public partial class AnimalList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Animal> GetAnimals([QueryString("id")] int? categoryId)
        {
            var _db = new WebForms.Models.AnimalContext();
            IQueryable<Animal> query = _db.Animals;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}