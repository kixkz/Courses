using FoodShortage.Contracts;

namespace FoodShortage.Models
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public Citizen(string id, string name, int age, string birthdate)
        {
               this.Id = id;
               this.Name = name;
               this.Age = age;
               this.Birthdate = birthdate;
        }

        public string Id { get; set; }

        public string Name { get; private set; }

        public int Age { get; private set; }
        
        public string Birthdate { get; set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
