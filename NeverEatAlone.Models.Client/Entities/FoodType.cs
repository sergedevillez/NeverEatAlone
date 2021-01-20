using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Client.Entities
{
    public class FoodType
    {
        public int FoodTypeId { get; private set; }
        public string FoodTypeName { get; private set; }

        public FoodType(string foodTypeName)
        {
            FoodTypeName = foodTypeName;
        }

        internal FoodType(int foodTypeId, string foodTypeName)
            : this(foodTypeName)
        {
            FoodTypeId = foodTypeId;
        }
    }
}
