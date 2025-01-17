namespace ZindanMaceracisi
{
    public class DragonLord : Enemy
    {
        public DragonLord(string name) : base(name, 500, 200, 10)
        {
            Skills.Add(new DragonBreathSkill());
        }

        public override void SpecialMove(Character target)
        {
            ConsoleHelper.WriteLineColored($"{Name} Korkunç ejderha nefesini püskürtüyor.", ConsoleColor.DarkRed);
            Skills[0].Use(this, target);
        }
    }
}