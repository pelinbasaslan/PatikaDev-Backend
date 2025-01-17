namespace ZindanMaceracisi
{
    public interface ICharacter
    {
        public string Name { get; }
        public int HP { get; set; }
        public int MaxHP { get; }

        public int MP { get; set; }
        public int MaxMP { get; }
        public int Level { get; }

        void Attack(ICharacter target);
        void TakeDamage(int damage);

    }
}