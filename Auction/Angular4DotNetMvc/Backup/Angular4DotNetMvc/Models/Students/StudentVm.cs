namespace Angular4DotNetMvc.Models.Students
{
    using System.ComponentModel.DataAnnotations;

    public class StudentVm
    {
        [Required(ErrorMessage = "Please enter a First Name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter an Email Address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Password.")]
        public string Password { get; set; }
    }
}
