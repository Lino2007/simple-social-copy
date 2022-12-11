namespace SOC.DataContracts.Response
{
    public abstract class BaseModelResponse
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}