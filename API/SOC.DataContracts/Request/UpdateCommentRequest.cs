namespace SOC.DataContracts.Request
{
    public class UpdateCommentRequest : UpdateDto
    {
        public string Content { get; set; } = null!;
        public bool Editable { get; set; }
    }
}