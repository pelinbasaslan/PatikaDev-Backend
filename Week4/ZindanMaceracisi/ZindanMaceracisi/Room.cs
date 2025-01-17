namespace ZindanMaceracisi
{
    public abstract class Room
    {
        public string Name { get; protected set; }
        public event Action<Hero> OnEnter;
        public event Action<Hero> OnExit;

        protected Room(string name)
        {
            Name = name;
        }

        public virtual void Enter(Hero hero)
        {
            ConsoleHelper.WriteLineColored($"[ODA] {hero.Name} adlı kahraman {Name} e giriyor.", ConsoleColor.Cyan);
            OnEnter?.Invoke(hero); //burası 0 anlama
            PerformAction(hero);
            OnExit?.Invoke(hero);
        }

        protected abstract void PerformAction(Hero hero);
    }
}