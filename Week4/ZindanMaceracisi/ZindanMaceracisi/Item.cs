using System.Reflection.Metadata;

namespace ZindanMaceracisi
{
    public abstract class Item
    {
        public string Name { get; }
        protected Item(string name)
        {
            Name = name;
        }
        public abstract void Use(Character character);

        public override bool Equals(object? obj)
        {
            if (obj is Item otherItems)
                return Name == otherItems.Name; //Other item name name'e eşitse true döndürecek.
            return false;

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}