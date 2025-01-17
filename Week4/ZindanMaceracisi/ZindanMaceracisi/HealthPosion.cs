namespace ZindanMaceracisi
{
    public class HealthPosion : Item
    {
        public HealthPosion() : base("Can İksiri")
        {


        }
        public override void Use(Character character)
        {
            int healAmount = 30;
            character.HP = Math.Min(character.MaxHP, character.HP + healAmount);
            ConsoleHelper.WriteLineColored($"[İYİLEŞME] {character.Name} can iksirini kafasına dikti. Vücuduna bir his yayıldı ve {healAmount} can yenilendi.", ConsoleColor.Green);
        }
    }
}