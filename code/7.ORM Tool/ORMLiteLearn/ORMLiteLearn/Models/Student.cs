using ServiceStack.DataAnnotations;

namespace ORMLiteLearn.Models
{
    public class Student
    {
        [PrimaryKey]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        [ForeignKey(typeof(Collage))]
        public int CollageId { get; set; }
        [ForeignKey(typeof(City))]
        public int CityId { get; set; }
    }
}