using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamesthew.com.Models;

namespace Jamesthew.com.Controllers
{
    public class RecipeController : Controller
    {

        List<Recipe> li = new List<Recipe>();

        public RecipeController()
        {

            li.Add(new Recipe() { Id = 1, Name = "Creamy Red Rice Risotto Recipe",
                Ingredients="Ingredients for Creamy Red Rice Risotto Recipe Red rice 1Â½ cups Butter 4 tablespoons Onion sliced 1 medium Garlic cloves finely chopped 2-3 Mixed herbs fresh, chopped 1 tablespoon Vegetable stock 6 cups Salt to taste Black peppercorns crushed 10-12 Frozen green peas Â½ cup",
                                  Method = "Heat butter in a non-stick pan. Add onion, garlic and mixed herbs, mix well and sautÃ© till onion turns golden brown.",Type="Free"
            });
            li.Add(new Recipe()
            {
                Id = 2,
                Name = "Creamy Red Rice Risotto Recipe",
                Ingredients = "Ingredients for Creamy Red Rice Risotto Recipe Red rice 1Â½ cups Butter 4 tablespoons Onion sliced 1 medium Garlic cloves finely chopped 2-3 Mixed herbs fresh, chopped 1 tablespoon Vegetable stock 6 cups Salt to taste Black peppercorns crushed 10-12 Frozen green peas Â½ cup",
                Method = "Heat butter in a non-stick pan. Add onion, garlic and mixed herbs, mix well and sautÃ© till onion turns golden brown.",
                Type = "Free"
            });
            li.Add(new Recipe()
            {
                Id = 3,
                Name = "Creamy Red Rice Risotto Recipe",
                Ingredients = "Ingredients for Creamy Red Rice Risotto Recipe Red rice 1Â½ cups Butter 4 tablespoons Onion sliced 1 medium Garlic cloves finely chopped 2-3 Mixed herbs fresh, chopped 1 tablespoon Vegetable stock 6 cups Salt to taste Black peppercorns crushed 10-12 Frozen green peas Â½ cup",
                Method = "Heat butter in a non-stick pan. Add onion, garlic and mixed herbs, mix well and sautÃ© till onion turns golden brown.",
                Type = "Free"
            });
            li.Add(new Recipe()
            {
                Id = 4,
                Name = "Creamy Red Rice Risotto Recipe",
                Ingredients = "Ingredients for Creamy Red Rice Risotto Recipe Red rice 1Â½ cups Butter 4 tablespoons Onion sliced 1 medium Garlic cloves finely chopped 2-3 Mixed herbs fresh, chopped 1 tablespoon Vegetable stock 6 cups Salt to taste Black peppercorns crushed 10-12 Frozen green peas Â½ cup",
                Method = "Heat butter in a non-stick pan. Add onion, garlic and mixed herbs, mix well and sautÃ© till onion turns golden brown.",
                Type = "Paid"
            });
            li.Add(new Recipe()
            {
                Id = 5,
                Name = "Creamy Red Rice Risotto Recipe",
                Ingredients = "Ingredients for Creamy Red Rice Risotto Recipe Red rice 1Â½ cups Butter 4 tablespoons Onion sliced 1 medium Garlic cloves finely chopped 2-3 Mixed herbs fresh, chopped 1 tablespoon Vegetable stock 6 cups Salt to taste Black peppercorns crushed 10-12 Frozen green peas Â½ cup",
                Method = "Heat butter in a non-stick pan. Add onion, garlic and mixed herbs, mix well and sautÃ© till onion turns golden brown.",
                Type = "Paid"
            });
            
        }

        //
        // GET: /James/
        public ActionResult Index()
        {

            return View(li);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var editing=li.Find(d => d.Id == id);

            return View(editing);
        }
        public ActionResult Delete(int id)
        {

            var editing = li.Find(d => d.Id == id);

            return View(editing);
        }
        public ActionResult Details(int id)
        {

            var editing = li.Find(d => d.Id == id);

            return View(editing);
        }

	}
}