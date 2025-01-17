namespace ZindanMaceracisi
{
    public class Goblin : Enemy
    {
        public Goblin(string name) : base(name, 30, 10, 1)
        {
            Skills.Add(new SneakAttackSkill());
        }

        public override void SpecialMove(Character target)
        {
            ConsoleHelper.WriteLineColored($"{Name} sinsi bir saldırı yapıyor", ConsoleColor.DarkRed);
            Skills[0].Use(this, target);
        }
    }
}