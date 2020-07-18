using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern.Builder.Interfaces;

namespace DesignPattern.Builder
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float result = -1;
            foreach (Item item in items)
            {
                result += item.price();
            }

            return result;
        }

        public string GetMenuSummary()
        {
            StringBuilder result = new StringBuilder();

            foreach (Item item in items)
            {
                result.AppendLine($"Item : {item.name()} , Packing : {item.packing().pack()} , Price {item.price()}");
            }
            result.AppendLine($"Total : {GetCost()}");
            return result.ToString();
        }

    }
}
