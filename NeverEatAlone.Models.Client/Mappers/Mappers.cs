using NeverEatAlone.Models.Client.Entities;

#region Alias
using GlobalUser = NeverEatAlone.Models.Global.Entities.User;
using GlobalFood = NeverEatAlone.Models.Global.Entities.Food;
using GlobalFoodType = NeverEatAlone.Models.Global.Entities.FoodType;
using GlobalMeeting = NeverEatAlone.Models.Global.Entities.Meeting;
using GlobalHobby = NeverEatAlone.Models.Global.Entities.Hobby;
#endregion

namespace NeverEatAlone.Models.Client.Mappers
{
    public static class Mappers
    {
        #region User
        public static GlobalUser ToGlobal(this User entity)
        {
            return new GlobalUser()
            {
                UserId = entity.UserId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                Password = entity.Password,
                IdPhoto = entity.IdPhoto,
            };
        }

        public static User ToClient(this GlobalUser entity)
        {
            //No password
            return new User(entity.UserId, entity.FirstName, entity.LastName, entity.Email, entity.IdPhoto);
        }
        #endregion

        #region Food
        public static GlobalFood ToGlobal(this Food entity)
        {
            return new GlobalFood()
            {
                FoodId = entity.FoodId,
                FoodName = entity.FoodName
            };
        }

        public static Food ToClient(this GlobalFood entity)
        {
            return new Food(entity.FoodId, entity.FoodName);
        }
        #endregion

        #region FoodType
        public static GlobalFoodType ToGlobal(this GlobalFoodType entity)
        {
            return new GlobalFoodType()
            {

            }
        }
        #endregion
    }
}
