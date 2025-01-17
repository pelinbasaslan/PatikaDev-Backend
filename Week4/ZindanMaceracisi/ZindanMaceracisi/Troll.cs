namespace ZindanMaceracisi
{
    public class Troll : Enemy
    {
        public Troll(string name) : base(name, 100, 20, 3)
        {
            Skills.Add(new SmashSkill());
        }

        public override void SpecialMove(Character target)
        {
            ConsoleHelper.WriteLineColored($"{name} olan güçlü bir ezme saldırısı yapıyor.", ConsoleColor.DarkBlue);
            Skills[0].Use(this, target)
        }
    }
}