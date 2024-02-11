namespace EjadTask.Ejad.Domain.Data.Entities
{
    public class Horse
    {
        public  int Id { get; set; }

        public string Name { get; set; }

        public ICollection<samurai> Samurais { get; set; }
    }
}
