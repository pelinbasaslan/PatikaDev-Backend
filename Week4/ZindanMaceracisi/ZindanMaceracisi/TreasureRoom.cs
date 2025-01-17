namespace ZindanMaceracisi
{
    public class TreasureRoom : Room
    {
        private Item _treasure;
        public TreasureRoom(string name, Item treasure) : base(name)
        {
            treasure = _treasure;
        }

        protected override void PerformAction(Hero hero)
        {
            ConsoleHelper.WriteLineColored($"[HAZİNE] {Name} odasında gıcırdayan bir kapıyı açtınız. WOWW {_treasure.Name} hazinesini buldunuz.", ConsoleColor.Red);
            hero.AddItemToInventory(_treasure);
        }
    }
}