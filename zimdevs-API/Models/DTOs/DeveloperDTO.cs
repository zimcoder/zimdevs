using System;

namespace zimdevsapi.Models.DTOs
{
    public class DeveloperDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ProfilePhotoUrl { get; set; }
    }
}
