namespace EjadTask.Sharedkernal.Data
{
   
        public interface IEntity<PrimaryKey>
        {
            PrimaryKey Id { get; set; }
        }
    }

