namespace ViewsExample.Models
{
    public class PersonModel
    {
        public PersonModel() { } //empty constructor
        public PersonModel(string name, DateTime dob, Gender gender) 
        {
            Name = name;
            DateOfBirth = dob;
            Gender = gender;
        }

        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender Gender { get; set; } = Gender.Other;
    }
        public enum Gender
    {
        Male, Female, Other
    }
}
