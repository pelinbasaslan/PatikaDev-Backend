namespace ZindanMaceracisi
{
    public class RestRoom : Room
    {
        public RestRoom(string name) : base(name)
        {
        }

        protected override void PerformAction(Hero hero)
        {
            ConsoleHelper.WriteLineColored($"[DİNLENME] {Name} odası dinlenme odası. {hero.Name} adlı kahraman burada HPsini ve MPsini fulledi", ConsoleColor.Yellow);
            hero.HP = hero.MaxHP;
            hero.MP = hero.MaxMP;

        }
    }
}