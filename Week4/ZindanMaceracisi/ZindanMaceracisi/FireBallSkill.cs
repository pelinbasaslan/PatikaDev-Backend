namespace ZindanMaceracisi
{
    public class FireBallSkill : Skill
    {
        public FireBallSkill() : base("Ateş Topu", 5)
        {

        }
        public override int Use(Character user, ICharacter target)
        {
            return user.Level * 3;
        }
    }
}