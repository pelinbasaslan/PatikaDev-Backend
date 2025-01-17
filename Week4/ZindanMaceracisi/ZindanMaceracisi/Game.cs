namespace ZindanMaceracisi
{
    public class Game
    {
        private Hero _hero;
        private List<Room> _rooms;
        private DragonLord _dragonLord;

        public Game()
        {
            InitializedGame();
        }

        private void InitializedGame()
        {
            _hero = new Hero("Süper Maceracı");
            _rooms = new List<Room>
            {
                CreateBattleRoom("Karanlık Koridor", new Goblin("Sinsi Goblin")),
                new TreasureRoom("Eski Hazine Odası", new HealthPosion()),
                new RestRoom("Huzurlu Bahçe"),
                CreateBattleRoom("Ateş Çukuru", new Troll("Güçlü Troll")),
                new TreasureRoom("Gizli KAsa", new ManaPosion()),
                new RestRoom("Şifalı Pınar"),
                CreateBattleRoom("Büyücünün Kulesi", new Wizard("Kötü Büyücü")),
            };
            _dragonLord = new DragonLord("Kızıl Ejder");

        }

        private BattleRoom CreateBattleRoom(string name, Enemy enemy)
        {
            var battleRoom = new BattleRoom(name, enemy);
            battleRoom.OnBattle += Battle;

            return battleRoom;
        }

        public void Start()
        {
            ConsoleHelper.WriteLineColored($"====Zindan Macerasına Hoşgeldiniz.====", ConsoleColor.Magenta);
            ConsoleHelper.WriteLineColored($" Siz {_hero.Name}, zindandan kaçmaya çalışan cesür bir kahramansınız.", ConsoleColor.Red);

            foreach (var room in _rooms)
            {
                if (_hero.HP <= 0)
                {
                    ConsoleHelper.WriteLineColored($"[OYUN BİTTİ] Maalesef yenildiniz. ", ConsoleColor.Red);
                    return;
                }
                room.Enter(_hero);
                DisplayHeroStatus();

            }
            if (_hero.HP > 0)
            {
                FinalBossBattle();
            }
        }


    }
}