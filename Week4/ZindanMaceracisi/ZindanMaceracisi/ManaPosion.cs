namespace ZindanMaceracisi
{
    public class ManaPosion : Item
    {
        public ManaPosion() : base("Mana İksiri")
        {

        }
        public override void Use(Character character)
        {
            int manaAmount = 20;
            character.MP = Math.Min(character.MaxMP, character.MP + manaAmount);
            ConsoleHelper.WriteLineColored($"[MANA] {character.Name} Mana iksirini içti. {manaAmount} kadar manası yenilendi.", ConsoleColor.Blue);
        }
    }
}