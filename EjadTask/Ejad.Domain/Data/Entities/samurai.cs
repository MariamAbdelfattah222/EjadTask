namespace EjadTask.Ejad.Domain.Data.Entities
{
    public class samurai
    {
        public int Id { get; set; }
        public int HorseId { get; set; }
        public Horse Horse { get; set; }
        public int BattleId { get; set; }
        public Battle Battle { get; set; }
    }
}
