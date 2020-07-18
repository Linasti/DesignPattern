using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Builder;

namespace DesignPattern.Test.Builder
{
    [TestFixture]
    public class BuilderTest
    {
        [Test]
        public void TestMethod()
        {
          MealBuilder mealBuilder = new MealBuilder();

          Meal vegMeal = mealBuilder.PrepareVegMeal();
          string vegSummuary = vegMeal.GetMenuSummary();
          Assert.AreEqual("Item : Beg burger , Packing : DesignPattern.Builder.Packings.Bottle , Price 25\r\nItem : Coke , Packing : DesignPattern.Builder.Packings.Bottle , Price 30\r\n",vegSummuary);
          
          Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
          string nonVezgSummary = nonVegMeal.GetMenuSummary();
          Assert.AreEqual("Item : chicken burger , Packing : DesignPattern.Builder.Packings.Bottle , Price 50.5\r\nItem : Persi , Packing : DesignPattern.Builder.Packings.Bottle , Price 35\r\n", nonVezgSummary);

        }
    }
}
