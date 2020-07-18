using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Builder.Models;

namespace DesignPattern.Builder
{
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal result = new Meal();
            result.AddItem(new VegBurger());
            result.AddItem(new Coke());
            return result;
        }

        public Meal PrepareNonVegMeal()
        {
            Meal result = new Meal();
            result.AddItem(new ChickenBurger());
            result.AddItem(new Pepsi());
            return result;
        }
    }
}
