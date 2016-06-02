using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthyfood;
using StockFood;

namespace HealthyFoodTests
{
    [TestFixture]

    public class T4RecipesManagement

    {
        [Test]
        public void AddHealthyrecipe_already_exists_and_find_Recipes()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("steak fritte", recipes, des));
        }

        [Test]
        public void FindHealthyRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(""));
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(null));
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(" "));
            Assert.Throws<NullReferenceException>(() => All.FindHealthyrecipe(" \t\r\n"));

            Recipe r1 = All.FindHealthyrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));

            Assert.Throws<ArgumentException>(() => All.FindHealthyrecipe("pomme au four"));

        }

        [Test]
        public void RemoveHealthyRecipe_correctly()
        {
            AllRecipe All = new AllRecipe();
            Ingredient i = new Ingredient("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredient> recipes = new List<Ingredient> { i };
            string des = "descritption";
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Recipe r1 = All.FindHealthyrecipe("steak fritte");
            Assert.That(r1, Is.EqualTo(r));
            bool result = All.RemoveHealthyrecipe(r);
            Assert.That(result, Is.EqualTo(true));
            Assert.That(All.RemoveHealthyrecipe(r1), Is.EqualTo(false));

        }
    }
}