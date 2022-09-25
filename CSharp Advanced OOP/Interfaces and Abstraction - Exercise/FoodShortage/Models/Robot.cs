using FoodShortage.Contracts;

namespace FoodShortage.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }

        public string Id { get; set; }

        public string Model { get; private set; }
    }
}
