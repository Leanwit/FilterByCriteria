using System;

namespace src.CsharpBasicSkeleton.Items.Domain
{
    public class Item
    {
        public Guid Id { get; }
        public string Name { get; }
        public int Priority { get; }
        public bool IsCompleted { get; }


        public Item(Guid id, string name, int priority = 0)
        {
            Id = id;
            Name = name;
            Priority = priority;
            IsCompleted = false;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as Item;
            if (item == null) return false;

            return Id == item.Id && Name == item.Name && IsCompleted == item.IsCompleted && Priority == item.Priority;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, IsCompleted, Priority);
        }
    }
}