namespace BCP.Business.Models
{
    public class Token
    {
        public class TokenPublic
        {

            public string publicToken { get; set; }

            public string appUserId { get; set; }
        }
        public class TokenPrivate
        {

            public string PrivateToken { get; set; }

            public string AppUserId { get; set; }
        }
        public class PublicPrivateToken
        {

            public string PublicToken { get; set; }

            public string PrivateToken { get; set; }

            public string AppUserId { get; set; }
        }
    }
}
