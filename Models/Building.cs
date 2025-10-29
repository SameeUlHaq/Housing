namespace Housing.Models
{
    public class Building
    {
        public int Id { get; }
        public string Name { get; }
        public string Address { get; }

        public Building(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public override string ToString() => $"{Name}, {Address}";
    }
}
