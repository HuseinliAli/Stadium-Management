namespace Framework.Entities.Users
{
    public class OperationClaim :BaseEntity, IEntity
    {
        public string Name { get; set; }

        public virtual List<UserOperation> UserOperations { get; set; }
    }
}
