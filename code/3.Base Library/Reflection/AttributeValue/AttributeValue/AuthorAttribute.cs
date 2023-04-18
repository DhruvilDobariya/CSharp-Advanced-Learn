namespace AttributeValue
{
    public class AuthorAttribute : Attribute
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public AuthorAttribute(int AuthorId, string AuthorName)
        {
            this.AuthorId = AuthorId;
            this.AuthorName = AuthorName;
        }
    }
}
