namespace Infrastracture
{
    public class PlayableCharacter
    {
        public Guid UserId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Object Class { get; set; }
        public int Lifespan { get; set; }

    }
}
