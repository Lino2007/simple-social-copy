namespace SOC.DataContracts.Request
{
    public class UpdateCommentRequest : UpdateRequest
    {
        public string Content { get; set; } = null!;
        public bool Editable { get; set; }
    }
}