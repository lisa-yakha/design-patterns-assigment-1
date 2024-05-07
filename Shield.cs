using System;

namespace RandomItems
{
    public class Shield : Item
    {
        public int defenseValue{get; set; }
        public override void UseItem()
        {
            Console.WriteLine("Shield used");
        }
    }
}