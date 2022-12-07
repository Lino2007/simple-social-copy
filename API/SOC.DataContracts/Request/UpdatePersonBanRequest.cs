namespace SOC.DataContracts.Request
{
    public class UpdatePersonBanRequest : UpdateRequest
    {
        public bool Active { get; set; }
        public DateTime? ActiveUntil { get; set; }
        public string Reason { get; set; } = null!;
    }
}