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

    public class T2Stocks
    {
        [Test]
        public void t01_add_ingredient_with_correct_category()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande humaine", "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient(" ", "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient(null, "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("", "lait", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient(" \t\r\n", "lait", 100, date));
            Ingredients i = stocks.AddIngredient("viande", "lait", 100, date);
            Assert.That(Stocks._stock.ContainsKey(Stocks.naming(i)), Is.EqualTo(true));
        }

        [Test]
        public void t02_add_ingredient_with_correct_name()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "poussin", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", " ", 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", null, 100, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", " \t\r\n", 100, date));
        }

        [Test]
        public void t03_add_ingredient_with_correct_balance_and_expiration_date()
        {
            Stocks stocks = new Stocks();
            DateTime date = new DateTime(2017, 10, 10);
            DateTime date1 = new DateTime(2008, 10, 10);
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "steak de boeuf", 0, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "steak de boeuf", -10, date));
            Assert.Throws<ArgumentException>(() => stocks.AddIngredient("viande", "steak de boeuf", 100, date1));

        }

    }

}
