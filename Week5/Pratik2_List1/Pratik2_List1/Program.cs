List<string> guests = new List<string>()
{
"Bülent Ersoy",
"Ajda Pekkan",
"Ebru Gündeş"
};

guests.Add("Hadise");
guests.Add("Hande Yener");
guests.Add("Tarkan");
guests.Add("Funda Arar");
guests.Add("Demet Akalın");

Console.WriteLine("Davetliler Listesi:");
int index = 1;
foreach (var guest in guests)
{
    Console.WriteLine(index + " - " + guest);
    index++;
}
