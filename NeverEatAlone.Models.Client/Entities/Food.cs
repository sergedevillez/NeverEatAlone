using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Client.Entities
{
    public class Food
    {
        public int FoodId { get; private set; }
        public string FoodName { get; private set; }
        
        public Food(string foodName)
        {
            FoodName = foodName;
        }

        internal Food(int foodId, string foodName)
            : this(foodName)
        {
            FoodId = foodId;
        }
    }
}
