namespace PersonInfo
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }
        public string Id { get; set; }
    }
}
