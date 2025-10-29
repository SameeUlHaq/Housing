namespace Housing.Models
{
    public class Room
    {
        public int Id { get; }
        public string Number { get; set; }
        public RoomType Type { get; set; }
        public RoomStatus Status { get; set; }
        public Building Building { get; set; }

        public Room(int id, string number, RoomType type, RoomStatus status, Building building)
        {
            Id = id;
            Number = number;
            Type = type;
            Status = status;
            Building = building;
        }

        public bool IsAvailable() => Status == RoomStatus.Available;

        public override string ToString() =>
            $"Room {Number} - {Type} - {Status} - {Building.Name}";
    }
}
