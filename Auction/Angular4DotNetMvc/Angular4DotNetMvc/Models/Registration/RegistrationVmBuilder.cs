namespace Angular4DotNetMvc.Models.Registration
{
    using Angular4DotNetMvc.Models.Courses;
    using Angular4DotNetMvc.Models.Instructors;

    public class RegistrationVmBuilder
    {
        public CourseVm[] GetSerializedCourses()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CREA101", Name = "Care of magical creatures", Instructor = "John Doe"},
                new CourseVm {Number = "DARK502", Name = "Defense against the dark arts", Instructor = "Severus Snape"},
                new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGon"}
            };
            return courses;
        }

        public CourseVm[] GetCourses()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CREA101", Name = "Care of magical creatures", Instructor = "John Doe"},
                new CourseVm {Number = "DARK502", Name = "Defense against the dark arts", Instructor = "Severus Snape"},
                new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGon"}
            };
            return courses;
        }

        public InstructorVm[] GetSerializedInstructors()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "John Doe", Email = "john.doe@email.com", RoomNumber = 101},
                new InstructorVm {Name = "Severus Snape", Email = "severus.snape@email.com", RoomNumber = 502},
                new InstructorVm {Name = "Minerva McGon", Email = "minerva.mcgon@email.com", RoomNumber = 201}
            };
            return instructors;
        }

        public InstructorVm[] GetInstructors()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "John Doe", Email = "john.doe@email.com", RoomNumber = 101},
                new InstructorVm {Name = "Severus Snape", Email = "severus.snape@email.com", RoomNumber = 502},
                new InstructorVm {Name = "Minerva McGon", Email = "minerva.mcgon@email.com", RoomNumber = 201}
            };
            return instructors;
        }
    }
}