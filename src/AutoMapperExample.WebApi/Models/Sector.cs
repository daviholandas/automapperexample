namespace AutoMapperExample.WebApi.Models
{
    public class Sector
    {
        public Sector(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private Sector(){}
        
        public int Id {get; private set;}
        public string Name { get; private set; }

        public override string ToString()
            => $"{Name}";
    }
}