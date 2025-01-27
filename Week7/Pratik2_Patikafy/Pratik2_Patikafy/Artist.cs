namespace Pratik2_Patikafy
{
    public class Artist
    {
        public string Name { get; set; }
        public string Genre { get; set; }    
        public int DateOfDebut { get; set; }
        public string AlbumSales { get; set; }

        public Artist(string name, string genre, int dateDebut, string albumSales)
        {
            Name = name;
            Genre = genre;
            DateOfDebut = dateDebut;
            AlbumSales = albumSales;
        }

        public Artist()
        {
            
        }

        public void DisplayNameInfo()
        {
            Console.WriteLine(Name);
        }

    }
}