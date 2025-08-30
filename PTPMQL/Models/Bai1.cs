namespace PTPMQL.Models
{
    public class Bai1
    {
        public string? FullName { get; set; }
        public int YearOfBirth { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }
    }
}