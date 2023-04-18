namespace AttributeValue
{
    public class Book
    {
        [Author(1, "Dhruvil Dobariya")]
        public int BookId { get; set; }
        [Author(2, "Dhaval Dobariya")]
        public string Name { get; set; }
    }
}
