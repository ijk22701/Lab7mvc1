namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } //tinfo200:[2021-03-12-ijk22701-dykstra1] - Question mark means it is nullable, enum above.
        public Student Student { get; set; }
    }
}