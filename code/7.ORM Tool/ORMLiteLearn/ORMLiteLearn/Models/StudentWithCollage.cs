﻿namespace ORMLiteLearn.Models
{
    public class StudentWithCollage
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        //public int CollageId { get; set; }
        //public int CityId { get; set; }
        public string Collage { get; set; }
        public string City { get; set; }
    }
}
