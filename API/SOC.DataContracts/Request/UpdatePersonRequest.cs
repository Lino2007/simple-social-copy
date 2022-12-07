namespace SOC.DataContracts.Request
{
    public class UpdatePersonRequest : UpdateRequest
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Bio { get; set; }
        public string Country { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
    }
}