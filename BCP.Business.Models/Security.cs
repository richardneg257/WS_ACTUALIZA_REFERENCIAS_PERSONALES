namespace BCP.Business.Models
{
    public class SecurityRequest : Token.TokenPublic
    {
        public string Text { get; set; }
        public bool Encrypt { get; set; }
        public string SegCryptName { get; set; }
    }

    public class SecurityResponse
    {
        public string Text { get; set; }
    }
}
