namespace CalorieCoach.DAL.Entities
{
    public class FoodItem:BaseEntity
    {
        public int MealRecordId { get; set; }

        public MealRecord MealRecord { get; set; }

        public int FoodId { get; set; }
        
    }
}