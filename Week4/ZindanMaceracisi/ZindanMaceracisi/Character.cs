using System.Security.Principal;
using ZindanMaceracisi;

public abstract class Character : ICharacter
{
    public string Name { get; }

    public int HP { get; set; }

    public int MaxHP { get; protected set; }

    public int MP { get; set; }

    public int MaxMP { get; protected set; }

    public int Level { get; protected set; }

    protected Random Random { get; } = new Random();

    public List<Skill> Skills { get; } = new List<Skill>();//bu kısmı anlamadım


    protected Character(string name, int maxHp, int maxMp, int level)
    {
        Name = name;
        MaxHP = maxHp;
        MaxMP = maxMp;
        Level = level;
    }

    public virtual void Attack(ICharacter target)
    {
        int damage = Random.Next(Level, Level * 2);
        ConsoleHelper.WriteLineColored($"[SALDIRI] {Name}, {target.Name}'e {damage} hasar veriyor. POW!! BAM!!", ConsoleColor.Yellow);
        target.TakeDamage(damage);
    }

    public virtual void TakeDamage(int damage)
    {
        HP -= damage;
        ConsoleHelper.WriteLineColored($"[HASAR] {Name} {damage} hasar alıyor. Ayy! Kalan HP: {HP}", ConsoleColor.Red);
    }

    public virtual void UseSkill(Skill skill, ICharacter target)
    {
        if (MP >= skill.MPCost)
        {
            MP -= skill.MPCost;
            int damage = skill.Use(this, target);
            ConsoleHelper.WriteLineColored($"[BECERİ KULLANILDI.]{Name} {target.Name}'e karşı {skill.Name} kullanıyor.", ConsoleColor.DarkGray);
            if (damage > 0)
            {
                target.TakeDamage(damage);
            }
            else
            {
                ConsoleHelper.WriteLineColored($"{Name}'in {skill.Name} kullanmak için yeterli MPsi yok.", ConsoleColor.DarkRed);
            }
        }
    }

}