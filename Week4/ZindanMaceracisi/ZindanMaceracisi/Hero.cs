namespace ZindanMaceracisi
{
    public class Hero : Character
    {
        public Hero(string name, int maxHp, int maxMp, int level) : base(name, maxHp, maxMp, level)
        {

        }
        public Hero(string name) : base(name, 100, 50, 1)
        {
            Skills.Add(new FireBallSkill());
            Skills.Add(new HealingSkill());
        }
        public int Experience { get; private set; } //bu kısmı anlamadım get set kısmını tam anlamadım genel olarak.

        public List<Item> Inventory { get; } = new List<Item>();

        public void AddItemToInventory(Item item)
        {
            Inventory.Add(item);
            ConsoleHelper.WriteLineColored($"[EŞYA] {Name} yeni bir {item.Name} buldu.", ConsoleColor.Green);
        }

        public void UseItem(Item item)
        {
            if (Inventory.Contains(item))
            {
                item.Use(this);
                Inventory.Remove(item);
            }
            else
            {
                ConsoleHelper.WriteLineColored($"[HATA] Hay aksi kullanmaya çalıştığın {Name} in envanterinde {item.Name} yoktur.", ConsoleColor.DarkRed);
            }
        }

        public void GainExperience(int exp)
        {
            Experience += exp;
            ConsoleHelper.WriteLineColored($"[DENEYİM] {Name} {exp} puan deneyime eklendi.", ConsoleColor.DarkRed);

            if (Experience >= 100 * Level)
            {
                LevelUp();
            }

        }

        public void LevelUp()
        {
            Level += 1;
            MaxHP += 20;
            MaxMP += 10;

            HP = MaxHP;
            MP = MaxMP;

            Experience -= 100 * (Level - 1);

            ConsoleHelper.WriteLineColored($"[SEVİYE ATLADI] {Name} seviye atladı. ", ConsoleColor.Magenta);
        }

    }
}