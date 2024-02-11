namespace EjadTask.Ejad.Domain.Data.Entities
{
    public class Battle
    {
        public int Id { get; set; }
       

        public ICollection<samurai> Samurais { get; set; }
    }
}
