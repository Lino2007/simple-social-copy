namespace SOC.DataContracts.Request
{
    public class AddPersonBanRequest
    {
        public bool Active { get; set; }
        public DateTime? ActiveUntil { get; set; }
        public string Reason { get; set; } = null!;
        public Guid PersonId { get; set; }
    }
}