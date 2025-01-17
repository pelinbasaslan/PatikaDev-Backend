namespace ZindanMaceracisi
{
    public class Wizard : Enemy
    {
        public Wizard(string name) : base(name, 50, 100, 5)
        {
            Skills.Add(new FireBallSkill()); //burada class diye mi new ile yapıyorduk???
        }

        public override void SpecialMove(Character target)
        {
            ConsoleHelper.WriteLineColored($"{Name} bir ateş topu fırlatıyor.", ConsoleColor.Red);
            Skills[0].Use(this, target);
        }
    }
}