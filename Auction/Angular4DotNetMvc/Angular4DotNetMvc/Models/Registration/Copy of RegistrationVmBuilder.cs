namespace Angular4DotNetMvc.Models.Registration
{
    using Angular4DotNetMvc.Models.Courses;
    using Angular4DotNetMvc.Models.Instructors;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class RegistrationVmBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };

            return registrationVm;
        }

        public string GetSerializedCourses()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CREA101", Name = "Care of magical creatures", Instructor = "John Doe"},
                new CourseVm {Number = "DARK502", Name = "Defense against the dark arts", Instructor = "Severus Snape"},
                new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGon"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializeCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            return serializeCourses;
        }

        public string GetSerializedInstructors()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "John Doe", Email = "john.doe@email.com", RoomNumber = 101},
                new InstructorVm {Name = "Severus Snape", Email = "severus.snape@email.com", RoomNumber = 502},
                new InstructorVm {Name = "Minerva McGon", Email = "minerva.mcgon@email.com", RoomNumber = 201}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializeInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            return serializeInstructors;
        }
    }
}