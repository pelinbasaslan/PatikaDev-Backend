namespace Pratik1_DI
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            string info = "Öğretmen adı soyadı: " + FirstName + " " + LastName;
            return info;
        }
    }
}