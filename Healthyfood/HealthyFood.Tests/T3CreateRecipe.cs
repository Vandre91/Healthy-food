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

    public class T3CreateRecipe

    {
        [Test]
        public void AddHealthyrecipe_with_correct_name()
        {
            AllRecipe All = new AllRecipe();
            Ingredients i = new Ingredients("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { i };
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe(null, recipes, des));
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe(" \t\r\n", recipes, "description"));
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe(" ", recipes, "description"));
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("", recipes, "description"));
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.That(r.Name, Is.EqualTo("steak fritte"));

        }

        [Test]
        public void AddYourrecipe_with_correct_name()
        {
            AllRecipe All = new AllRecipe();
            Ingredients i = new Ingredients("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { i };
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe(null, recipes, des));
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe(" \t\r\n", recipes, "description"));
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe(" ", recipes, "description"));
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe("", recipes, "description"));
            Recipe r = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.That(r.Name, Is.EqualTo("steak fritte"));

        }
        [Test]
        public void AddWorldrecipe_with_correct_name()
        {
            AllRecipe All = new AllRecipe();
            Ingredients i = new Ingredients("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { i };
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe(null, recipes, des));
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe(" \t\r\n", recipes, "description"));
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe(" ", recipes, "description"));
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe("", recipes, "description"));
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.That(r.Name, Is.EqualTo("steak fritte"));

        }

        [Test]
        public void AddHealthyrecipe_with_correct_list()
        {
            AllRecipe All = new AllRecipe();
            Ingredients i = new Ingredients("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { i };
            List<Ingredients> recipes1 = new List<Ingredients>();
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("steak fritte", recipes1, des));
            Recipe r = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.That(r._recette, Is.EqualTo(recipes));
        }

        [Test]
        public void AddYourRecipe_with_correct_list()
        {
            AllRecipe All = new AllRecipe();
            Ingredients i = new Ingredients("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { i };
            List<Ingredients> recipes1 = new List<Ingredients>();
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe("steak fritte", recipes1, des));
            Recipe r = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.That(r._recette, Is.EqualTo(recipes));
        }

        [Test]
        public void AddWorldRecipe_with_correct_list()
        {
            AllRecipe All = new AllRecipe();
            Ingredients i = new Ingredients("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { i };
            List<Ingredients> recipes1 = new List<Ingredients>();
            string des = "descritption";
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe("steak fritte", recipes1, des));
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.That(r._recette, Is.EqualTo(recipes));
        }

        [Test]
        public void test_description()
        {
            AllRecipe All = new AllRecipe();
            Ingredients i = new Ingredients("viande", "Steak de boeuf", 100, DateTime.Today);
            List<Ingredients> recipes = new List<Ingredients> { i };
            string des = "descritption";
            string des1 = null;
            string des2 = " ";
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe("steak fritte", recipes, des1));
            Assert.Throws<ArgumentException>(() => All.AddWorldrecipe("steak fritte", recipes, des2));
            Recipe r = All.AddWorldrecipe("steak fritte", recipes, des);
            Assert.That(r.Describe, Is.EqualTo(des));

            Assert.Throws<ArgumentException>(() => All.AddYourrecipe("steak fritte", recipes, des1));
            Assert.Throws<ArgumentException>(() => All.AddYourrecipe("steak fritte", recipes, des2));
            Recipe r1 = All.AddYourrecipe("steak fritte", recipes, des);
            Assert.That(r1.Describe, Is.EqualTo(des));

            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("steak fritte", recipes, des1));
            Assert.Throws<ArgumentException>(() => All.AddHealthyrecipe("steak fritte", recipes, des2));
            Recipe r2 = All.AddHealthyrecipe("steak fritte", recipes, des);
            Assert.That(r2.Describe, Is.EqualTo(des));
        }

        }
}
