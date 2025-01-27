namespace Pratik3_Patikaflix
{
    public class Comedy
    {
        public string NameComedy { get; set; }
        public string GenreComedy { get; set; }
        public string DirectorComedy { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine($"{NameComedy} isimli dizinin türü {GenreComedy}dir ve yönetmeni {DirectorComedy}dir.");
        }
    }


}