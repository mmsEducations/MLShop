namespace MLShop.Data.Entities
{
    public class BaseEntity
    {
        public int? Order { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationDate { get; set; }

    }
}


