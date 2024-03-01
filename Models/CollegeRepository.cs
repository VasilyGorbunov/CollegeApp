namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                StudentName = "Student 1",
                Email = "student1@app.com",
                Address = "Street 1"
            },
            new Student()
            {
                Id = 2,
                StudentName = "Student 2",
                Email = "student2@app.com",
                Address = "Street 2"
            }
        };
    }
}
