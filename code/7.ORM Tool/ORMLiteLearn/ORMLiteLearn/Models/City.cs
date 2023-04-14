using ServiceStack.DataAnnotations;

namespace ORMLiteLearn.Models
{
    // [Index(nameof(Email), IsUnique = true)]
    public class City
    {
        [PrimaryKey]
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
