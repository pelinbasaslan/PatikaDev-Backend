namespace ZindanMaceracisi
{
    public class BattleRoom : Room
    {
        private Enemy _enemy;
        public event Func<Hero, Enemy, bool> OnBattle;
        public BattleRoom(string name, Enemy enemy) : base(name)
        {
            enemy = _enemy;
        }

        protected override void PerformAction(Hero hero)
        {
            ConsoleHelper.WriteLineColored($"{Name} odasında gıcırdayan bir kapıyı açtınız. Eyvah. {_enemy.Name} düşmanı ile karşılaştınız.", ConsoleColor.Red);
            bool battleResult = OnBattle?.Invoke(hero, _enemy) ?? false;

            if (battleResult)
            {
                ConsoleHelper.WriteLineColored($"[ZAFER] {_enemy.Name} i yendiniz. Büyük zafer!!1", ConsoleColor.Blue);
            }
            else
            {
                ConsoleHelper.WriteLineColored($"[YENİLGİ] {_enemy.Name} karşısında yenildiniz.", ConsoleColor.Red);
            }
        }

        private bool Battle(Hero hero, Enemy enemy) //bu kısımı anlamadım BattleRoom kısımlarını anlamdım.
        {
            while (hero.HP > 0 && enemy.HP > 0)
            {
                PerformTurn(hero, enemy);
                if (enemy.HP > 0)
                {
                    PerformTurn(enemy, hero);
                }
            }

            if (enemy.HP <= 0)
            {
                ConsoleHelper.WriteLineColored("[ZAFER] BÜYÜK BİR ZAFER KAZANDINIZ.", ConsoleColor.Blue);
                hero.GainExperience(enemy.Level * 20);
                return true;
            }

            return false;

        }

        private void PerformTurn(ICharacter attacker, ICharacter defender)
        {
            ConsoleHelper.WriteLineColored($" [SIRA] {attacker.Name}in sırası;", ConsoleColor.Yellow);
            ConsoleHelper.WriteLineColored($"")
        }
    }
}