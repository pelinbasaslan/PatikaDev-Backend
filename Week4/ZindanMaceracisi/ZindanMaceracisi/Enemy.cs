namespace ZindanMaceracisi
{
    public abstract class Enemy : Character
    {
        protected Enemy(string name, int maxHp, int maxMp, int level) : base(name, maxHp, maxMp, level)
        {
        }

        public abstract void SpecialMove(Character target);
    }
}